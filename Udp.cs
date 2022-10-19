using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Collections.Concurrent;

namespace UDP_Transponder
{
    /// <summary>
    /// manage 2 threads and 1+n UdpClients to handling data sending and receiving
    /// </summary>
    internal class Udp
    {
        readonly IPEndPoint endPointListen;
        readonly UdpClient hostListen;
        readonly Thread threadListen;

        readonly List<Form1.SendBindingConfig> configSend;
        readonly List<IPEndPoint> endPointsSend;
        readonly List<UdpClient> hostsSend;
        readonly Thread threadSend;

        readonly ConcurrentQueue<(byte[] data, List<int> indexs)> tasks = new(); // thread safe
        bool cmdStop = false;
        public Udp(string hostIP, int hostPort, List<Form1.SendBindingConfig> sendConfig)
        {
            endPointListen = new IPEndPoint(IPAddress.Parse(hostIP), hostPort);
            hostListen = new UdpClient(endPointListen);

            configSend = sendConfig;
            hostsSend = new();
            endPointsSend = new List<IPEndPoint>();
            foreach (var cfg in sendConfig)
            {
                endPointsSend.Add(new IPEndPoint(IPAddress.Parse(cfg.IP), cfg.port));
                hostsSend.Add(new UdpClient());
            }

            threadListen = new(KeepListening);
            threadListen.IsBackground = true;
            threadListen.Start();
            
            threadSend = new(KeepSending);
            threadSend.IsBackground = true;
            threadSend.Start();
        }
        void KeepListening()
        {
            while (true)
            {
                if (cmdStop) break;
                try
                {
                    IPEndPoint endPointSender = new(IPAddress.Any, 0); // from which ip and port
                    byte[] buffer = hostListen.Receive(ref endPointSender);
                    string? msg = null;
                    try
                    {
                        msg = Encoding.ASCII.GetString(buffer, 0, buffer.Length);
                    }
                    catch { }
                    List<int> indexes = new();
                    for (int i = 0; i < this.configSend.Count; i++)
                    {
                        var cfg = this.configSend[i];
                        if (cfg.Regex != "" && (msg == null || !Regex.IsMatch(msg, cfg.Regex))) continue;
                        indexes.Add(i);
                    }
                    if (indexes.Count > 0)
                    {
                        tasks.Enqueue((buffer, indexes));
                    }
                }
                catch
                {
                    if (cmdStop) break;
                    throw;
                }
            }
        }
        void KeepSending()
        {
            while (true)
            {
                if (cmdStop) break;
                try
                {
                    if (tasks.IsEmpty)
                    {
                        Thread.Sleep(10);
                    }
                    if (tasks.TryDequeue(out var task))
                    {
                        foreach (var i in task.indexs)
                        {
                            hostsSend[i].Send(task.data, task.data.Length, endPointsSend[i]);
                        }
                    }
                }
                catch
                {
                    if (cmdStop) break;
                    throw;
                }

            }
        }
        ~Udp()
        {
            Stop();
        }
        public void Stop()
        {
            cmdStop = true;
            hostListen.Close();
            foreach (var host in hostsSend)
            {
                host.Close();
            }
        }
    }
}
