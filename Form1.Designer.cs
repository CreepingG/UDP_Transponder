namespace UDP_Transponder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_listen_port = new System.Windows.Forms.Label();
            this.label_ip = new System.Windows.Forms.Label();
            this.textBox_host_port = new System.Windows.Forms.TextBox();
            this.textBox_host_ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label_send = new System.Windows.Forms.Label();
            this.button_load = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button_load);
            this.splitContainer1.Panel2.Controls.Add(this.button_save);
            this.splitContainer1.Panel2.Controls.Add(this.button_start);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 632;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 127F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 245F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(632, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_listen_port);
            this.panel1.Controls.Add(this.label_ip);
            this.panel1.Controls.Add(this.textBox_host_port);
            this.panel1.Controls.Add(this.textBox_host_ip);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 121);
            this.panel1.TabIndex = 0;
            // 
            // label_listen_port
            // 
            this.label_listen_port.AutoSize = true;
            this.label_listen_port.Location = new System.Drawing.Point(388, 40);
            this.label_listen_port.Name = "label_listen_port";
            this.label_listen_port.Size = new System.Drawing.Size(46, 24);
            this.label_listen_port.TabIndex = 4;
            this.label_listen_port.Text = "Port";
            // 
            // label_ip
            // 
            this.label_ip.AutoSize = true;
            this.label_ip.Location = new System.Drawing.Point(158, 40);
            this.label_ip.Name = "label_ip";
            this.label_ip.Size = new System.Drawing.Size(26, 24);
            this.label_ip.TabIndex = 3;
            this.label_ip.Text = "IP";
            // 
            // textBox_host_port
            // 
            this.textBox_host_port.Location = new System.Drawing.Point(339, 67);
            this.textBox_host_port.Name = "textBox_host_port";
            this.textBox_host_port.Size = new System.Drawing.Size(150, 30);
            this.textBox_host_port.TabIndex = 2;
            this.textBox_host_port.Text = "12306";
            this.textBox_host_port.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_host_ip
            // 
            this.textBox_host_ip.Location = new System.Drawing.Point(99, 67);
            this.textBox_host_ip.Name = "textBox_host_ip";
            this.textBox_host_ip.Size = new System.Drawing.Size(150, 30);
            this.textBox_host_ip.TabIndex = 1;
            this.textBox_host_ip.Text = "127.0.0.1";
            this.textBox_host_ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(284, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Listen";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label_send);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(626, 317);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 100;
            this.dataGridView1.RowTemplate.Height = 32;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(570, 200);
            this.dataGridView1.TabIndex = 6;
            // 
            // label_send
            // 
            this.label_send.AutoSize = true;
            this.label_send.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_send.Location = new System.Drawing.Point(284, 17);
            this.label_send.Name = "label_send";
            this.label_send.Size = new System.Drawing.Size(57, 25);
            this.label_send.TabIndex = 1;
            this.label_send.Text = "Send";
            // 
            // button_load
            // 
            this.button_load.Location = new System.Drawing.Point(14, 234);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(138, 34);
            this.button_load.TabIndex = 2;
            this.button_load.Text = "Load Config";
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.LoadConfig);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(14, 156);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(138, 34);
            this.button_save.TabIndex = 1;
            this.button_save.Text = "Save Config";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.SaveConfig);
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(14, 70);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(138, 34);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.Start_Stop);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "UDP Transponder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label_listen_port;
        private Label label_ip;
        private TextBox textBox_host_port;
        private TextBox textBox_host_ip;
        private Label label1;
        private Panel panel2;
        private Label label_send;
        private Button button_start;
        private DataGridView dataGridView1;
        private Button button_load;
        private Button button_save;
    }
}