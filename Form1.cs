using Newtonsoft.Json;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace UDP_Transponder
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// save and load as json
        /// </summary>
        public class AllConfig
        {
            public List<SendBindingConfig> send;
            public string hostIP;
            public int hostPort;
            /// <summary>
            /// only for json deserialize
            /// </summary>
            public AllConfig()
            {
                send = new();
                hostIP = "";
                hostPort = 0;
            }
            public AllConfig(Form1 form)
            {
                hostIP = form.textBox_host_ip.Text;
                if (!Regex.IsMatch(hostIP, @"^\d+\.\d+\.\d+\.\d+$")) // 123.456.789.000
                {
                    throw new FormatException($"wrong ip:\"{hostIP}\"");
                }
                hostPort = int.Parse(form.textBox_host_port.Text);
                send = form.sendConfigs.Where(cfg=>cfg.port!=0).ToList();
            }
            public void Apply(Form1 form)
            {
                form.textBox_host_ip.Text = hostIP;
                form.textBox_host_port.Text = hostPort.ToString();
                form.sendConfigs.Clear();
                foreach(var cfg in send)
                {
                    form.sendConfigs.Add(cfg);
                }
                form.dataGridView1.DataSource = new BindingSource
                {
                    DataSource = form.sendConfigs
                };
            }
            public static void Save(Form1 form, string path = "config.json")
            {
                var s = JsonConvert.SerializeObject(new AllConfig(form));
                StreamWriter sw = new(path);
                sw.Write(s);
                sw.Close();
            }
            public static void Load(Form1 form, string path = "config.json")
            {
                StreamReader sr = new(path);
                var s = sr.ReadToEnd();
                sr.Close();
                var config = JsonConvert.DeserializeObject<AllConfig>(s);
                if (config != null)
                {
                    config.Apply(form);
                }
                else
                {
                    MessageBox.Show(s, "convert failed");
                }
            }
        }
        /// <summary>
        /// read and write by the table in GUI
        /// </summary>
        public class SendBindingConfig : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler? PropertyChanged;
            
            public string IP
            {
                get => ip; 
                set{
                    if (value == ip) return;
                    try
                    {
                        if (System.Text.RegularExpressions.Regex.IsMatch(value, @"^\d+\.\d+\.\d+\.\d+$"))
                        {
                            ip = value;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("??");
                    }
                }
            }
            [JsonIgnore]
            public string ip;
                  
            public string Port {
                get => port.ToString();
                set{
                    if (int.TryParse(value, out int val) && val >= 0)
                    {
                        port = val;
                    }
                }
            }
            [JsonIgnore]
            public int port;
            
            public string Regex { 
                get=>regex; 
                set {
                    if (value == regex) return;
                    regex = value;
                }
            }
            [JsonIgnore]
            public string regex;
            protected void OnPropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            public SendBindingConfig()
            {
                ip = "127.0.0.1";
                port = 0;
                regex = "";
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        ~Form1()
        {
            if (udp != null)
            {
                udp.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new BindingSource
            {
                DataSource = sendConfigs
            };
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private Udp? udp;
        private bool working = false;
        private readonly List<SendBindingConfig> sendConfigs = new()
        {
            new SendBindingConfig()
        };

        private void Start_Stop(object sender, EventArgs e)
        {
            if (working)
            {
                udp?.Stop();
                working = !working;
                dataGridView1.ReadOnly = false;
                button_start.Text = "Start";
                return;
            }
            try
            {
                if (!sendConfigs.Where(cfg => cfg.port != 0).Any())
                {
                    throw new Exception("at least 1 non-zero send port needed.");
                }
                string hostIP = textBox_host_ip.Text;
                int hostPort = int.Parse(textBox_host_port.Text);
                udp = new Udp(hostIP, hostPort, sendConfigs);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return;
            }
            working = !working;
            dataGridView1.ReadOnly = true;
            button_start.Text = "Stop";
        }

        private void SaveConfig(object sender, EventArgs e)
        {
            AllConfig.Save(this);
        }

        private void LoadConfig(object sender, EventArgs e) // TODO: specify load from which file
        {
            AllConfig.Load(this);
        }
    }
}