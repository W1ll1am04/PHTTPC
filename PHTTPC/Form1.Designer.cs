namespace PHTTPC
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.port_in = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ip_in = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.directory_in = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pypath_in = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ipbox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.dir_select = new System.Windows.Forms.FolderBrowserDialog();
            this.pyfind = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.ram_counter = new System.Windows.Forms.Timer(this.components);
            this.button8 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.status = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ram_total = new System.Windows.Forms.ToolStripStatusLabel();
            this.separator1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.process_ram_label = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.process_ram_alt = new System.Windows.Forms.Label();
            this.uptime_refresh = new System.Windows.Forms.Timer(this.components);
            this.uptime_display = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.status.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.button12);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 28);
            this.panel1.TabIndex = 0;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(846, 2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(58, 24);
            this.button12.TabIndex = 2;
            this.button12.TabStop = false;
            this.button12.Text = "Tweaks";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(905, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 24);
            this.button1.TabIndex = 1;
            this.button1.TabStop = false;
            this.button1.Text = "About";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.port_in);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ip_in);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.directory_in);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pypath_in);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(4, 322);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 148);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(331, 75);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(27, 23);
            this.button7.TabIndex = 10;
            this.button7.Text = "...";
            this.button7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(331, 53);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(27, 23);
            this.button6.TabIndex = 8;
            this.button6.Text = "...";
            this.button6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(281, 101);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(77, 21);
            this.button5.TabIndex = 5;
            this.button5.Text = "Clear config";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(8, 101);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(189, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Shutdown server at PHTTPC exit?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 121);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(354, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Update configuration...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // port_in
            // 
            this.port_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.port_in.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.port_in.Location = new System.Drawing.Point(47, 17);
            this.port_in.Name = "port_in";
            this.port_in.Size = new System.Drawing.Size(104, 14);
            this.port_in.TabIndex = 8;
            this.port_in.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "PORT:";
            // 
            // ip_in
            // 
            this.ip_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ip_in.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ip_in.Location = new System.Drawing.Point(27, 39);
            this.ip_in.Name = "ip_in";
            this.ip_in.Size = new System.Drawing.Size(267, 14);
            this.ip_in.TabIndex = 6;
            this.ip_in.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "IP:";
            // 
            // directory_in
            // 
            this.directory_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.directory_in.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.directory_in.Location = new System.Drawing.Point(60, 60);
            this.directory_in.Name = "directory_in";
            this.directory_in.Size = new System.Drawing.Size(267, 14);
            this.directory_in.TabIndex = 4;
            this.directory_in.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Directory:";
            // 
            // pypath_in
            // 
            this.pypath_in.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pypath_in.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pypath_in.Location = new System.Drawing.Point(91, 82);
            this.pypath_in.Name = "pypath_in";
            this.pypath_in.Size = new System.Drawing.Size(236, 14);
            this.pypath_in.TabIndex = 3;
            this.pypath_in.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Python location:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(824, 369);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 28);
            this.button3.TabIndex = 3;
            this.button3.Text = "Start HTTP.Server";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(824, 340);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 28);
            this.button4.TabIndex = 4;
            this.button4.Text = "Kill HTTP.Server";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ipbox
            // 
            this.ipbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ipbox.FormattingEnabled = true;
            this.ipbox.Location = new System.Drawing.Point(824, 401);
            this.ipbox.Name = "ipbox";
            this.ipbox.Size = new System.Drawing.Size(133, 69);
            this.ipbox.TabIndex = 5;
            this.ipbox.DoubleClick += new System.EventHandler(this.ipbox_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(793, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "IP(s)";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(738, 447);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(78, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Show IPv6";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // pyfind
            // 
            this.pyfind.FileName = "python.exe";
            this.pyfind.Filter = "Exe Files (.exe)|*.exe|All Files (*.*)|*.*";
            this.pyfind.ShowReadOnly = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(374, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 15;
            // 
            // ram_counter
            // 
            this.ram_counter.Interval = 500;
            this.ram_counter.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.55F);
            this.button8.Location = new System.Drawing.Point(51, 36);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(41, 24);
            this.button8.TabIndex = 17;
            this.button8.Text = "Stop";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(179, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Process ram usage counter controls:";
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.55F);
            this.button10.Location = new System.Drawing.Point(7, 36);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(41, 24);
            this.button10.TabIndex = 20;
            this.button10.Text = "Start";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.55F);
            this.button11.Location = new System.Drawing.Point(98, 36);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(52, 24);
            this.button11.TabIndex = 21;
            this.button11.Text = "Restart";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.LightGray;
            this.status.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.ram_total,
            this.separator1,
            this.toolStripStatusLabel2,
            this.process_ram_label});
            this.status.Location = new System.Drawing.Point(0, 475);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(962, 22);
            this.status.SizingGrip = false;
            this.status.TabIndex = 22;
            this.status.Text = "status";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(64, 17);
            this.toolStripStatusLabel1.Text = "Total RAM:";
            // 
            // ram_total
            // 
            this.ram_total.BackColor = System.Drawing.Color.Transparent;
            this.ram_total.Name = "ram_total";
            this.ram_total.Size = new System.Drawing.Size(57, 17);
            this.ram_total.Text = "ram_total";
            // 
            // separator1
            // 
            this.separator1.BackColor = System.Drawing.Color.Transparent;
            this.separator1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(20, 17);
            this.separator1.Text = "｜";
            this.separator1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.separator1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.separator1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(151, 17);
            this.toolStripStatusLabel2.Text = "Current process ram usage:";
            // 
            // process_ram_label
            // 
            this.process_ram_label.Name = "process_ram_label";
            this.process_ram_label.Size = new System.Drawing.Size(67, 17);
            this.process_ram_label.Text = "not started.";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.process_ram_alt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Controls.Add(this.button10);
            this.groupBox2.Location = new System.Drawing.Point(374, 402);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 68);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(151, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Ram usage:";
            // 
            // process_ram_alt
            // 
            this.process_ram_alt.AutoSize = true;
            this.process_ram_alt.Location = new System.Drawing.Point(214, 44);
            this.process_ram_alt.Name = "process_ram_alt";
            this.process_ram_alt.Size = new System.Drawing.Size(60, 13);
            this.process_ram_alt.TabIndex = 24;
            this.process_ram_alt.Text = "not started.";
            // 
            // uptime_refresh
            // 
            this.uptime_refresh.Interval = 1;
            this.uptime_refresh.Tick += new System.EventHandler(this.uptime_refresh_Tick);
            // 
            // uptime_display
            // 
            this.uptime_display.AutoSize = true;
            this.uptime_display.Location = new System.Drawing.Point(457, 386);
            this.uptime_display.Name = "uptime_display";
            this.uptime_display.Size = new System.Drawing.Size(60, 13);
            this.uptime_display.TabIndex = 24;
            this.uptime_display.Text = "not started.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(376, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Process uptime:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(962, 497);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.uptime_display);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ipbox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(978, 536);
            this.Name = "Form1";
            this.Text = "PHTTPC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox directory_in;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox pypath_in;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox port_in;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox ip_in;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ListBox ipbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.FolderBrowserDialog dir_select;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.OpenFileDialog pyfind;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer ram_counter;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel ram_total;
        private System.Windows.Forms.ToolStripStatusLabel separator1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel process_ram_label;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label process_ram_alt;
        private System.Windows.Forms.Timer uptime_refresh;
        private System.Windows.Forms.Label uptime_display;
        private System.Windows.Forms.Label label9;
    }
}

