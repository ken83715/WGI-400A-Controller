namespace WGI_400A
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.receivetextbox = new System.Windows.Forms.TextBox();
            this.sendtextbox = new System.Windows.Forms.TextBox();
            this.Port = new System.Windows.Forms.Label();
            this.BaudRate = new System.Windows.Forms.Label();
            this.Parity = new System.Windows.Forms.Label();
            this.Databits = new System.Windows.Forms.Label();
            this.Stopbits = new System.Windows.Forms.Label();
            this.portc = new System.Windows.Forms.ComboBox();
            this.baudratec = new System.Windows.Forms.ComboBox();
            this.parityc = new System.Windows.Forms.ComboBox();
            this.databitsc = new System.Windows.Forms.ComboBox();
            this.stopbitsc = new System.Windows.Forms.ComboBox();
            this.connect = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.Receive = new System.Windows.Forms.Label();
            this.logtextbox = new System.Windows.Forms.TextBox();
            this.log = new System.Windows.Forms.Label();
            this.savelog = new System.Windows.Forms.Button();
            this.samplestart = new System.Windows.Forms.Button();
            this.setsamplerate = new System.Windows.Forms.Label();
            this.sampleratetextbox = new System.Windows.Forms.TextBox();
            this.samplestop = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.checkconn = new System.Windows.Forms.Button();
            this.checkname = new System.Windows.Forms.Button();
            this.getvalue = new System.Windows.Forms.Button();
            this.mod00 = new System.Windows.Forms.Button();
            this.mod10 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.setparameters = new System.Windows.Forms.Button();
            this.labelchart = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // receivetextbox
            // 
            this.receivetextbox.Location = new System.Drawing.Point(13, 239);
            this.receivetextbox.Multiline = true;
            this.receivetextbox.Name = "receivetextbox";
            this.receivetextbox.Size = new System.Drawing.Size(633, 321);
            this.receivetextbox.TabIndex = 0;
            // 
            // sendtextbox
            // 
            this.sendtextbox.Location = new System.Drawing.Point(13, 61);
            this.sendtextbox.Multiline = true;
            this.sendtextbox.Name = "sendtextbox";
            this.sendtextbox.Size = new System.Drawing.Size(633, 117);
            this.sendtextbox.TabIndex = 1;
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Location = new System.Drawing.Point(10, 13);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(35, 15);
            this.Port.TabIndex = 2;
            this.Port.Text = "Port:";
            // 
            // BaudRate
            // 
            this.BaudRate.AutoSize = true;
            this.BaudRate.Location = new System.Drawing.Point(138, 13);
            this.BaudRate.Name = "BaudRate";
            this.BaudRate.Size = new System.Drawing.Size(69, 15);
            this.BaudRate.TabIndex = 3;
            this.BaudRate.Text = "Baud Rate:";
            // 
            // Parity
            // 
            this.Parity.AutoSize = true;
            this.Parity.Location = new System.Drawing.Point(266, 13);
            this.Parity.Name = "Parity";
            this.Parity.Size = new System.Drawing.Size(45, 15);
            this.Parity.TabIndex = 4;
            this.Parity.Text = "Parity:";
            // 
            // Databits
            // 
            this.Databits.AutoSize = true;
            this.Databits.Location = new System.Drawing.Point(394, 13);
            this.Databits.Name = "Databits";
            this.Databits.Size = new System.Drawing.Size(72, 15);
            this.Databits.TabIndex = 5;
            this.Databits.Text = "Datalength:";
            // 
            // Stopbits
            // 
            this.Stopbits.AutoSize = true;
            this.Stopbits.Location = new System.Drawing.Point(522, 13);
            this.Stopbits.Name = "Stopbits";
            this.Stopbits.Size = new System.Drawing.Size(57, 15);
            this.Stopbits.TabIndex = 6;
            this.Stopbits.Text = "Stopbits:";
            // 
            // portc
            // 
            this.portc.FormattingEnabled = true;
            this.portc.Items.AddRange(new object[] {
            "null"});
            this.portc.Location = new System.Drawing.Point(13, 32);
            this.portc.Name = "portc";
            this.portc.Size = new System.Drawing.Size(121, 23);
            this.portc.TabIndex = 7;
            this.portc.Text = "null";
            // 
            // baudratec
            // 
            this.baudratec.FormattingEnabled = true;
            this.baudratec.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "38400"});
            this.baudratec.Location = new System.Drawing.Point(141, 32);
            this.baudratec.Name = "baudratec";
            this.baudratec.Size = new System.Drawing.Size(121, 23);
            this.baudratec.TabIndex = 8;
            this.baudratec.Text = "9600";
            // 
            // parityc
            // 
            this.parityc.FormattingEnabled = true;
            this.parityc.Items.AddRange(new object[] {
            "Odd",
            "Even",
            "None"});
            this.parityc.Location = new System.Drawing.Point(269, 31);
            this.parityc.Name = "parityc";
            this.parityc.Size = new System.Drawing.Size(121, 23);
            this.parityc.TabIndex = 9;
            this.parityc.Text = "Odd";
            // 
            // databitsc
            // 
            this.databitsc.FormattingEnabled = true;
            this.databitsc.Items.AddRange(new object[] {
            "7",
            "8"});
            this.databitsc.Location = new System.Drawing.Point(397, 31);
            this.databitsc.Name = "databitsc";
            this.databitsc.Size = new System.Drawing.Size(121, 23);
            this.databitsc.TabIndex = 10;
            this.databitsc.Text = "7";
            // 
            // stopbitsc
            // 
            this.stopbitsc.FormattingEnabled = true;
            this.stopbitsc.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.stopbitsc.Location = new System.Drawing.Point(525, 31);
            this.stopbitsc.Name = "stopbitsc";
            this.stopbitsc.Size = new System.Drawing.Size(121, 23);
            this.stopbitsc.TabIndex = 11;
            this.stopbitsc.Text = "One";
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(652, 12);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(125, 30);
            this.connect.TabIndex = 12;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(652, 84);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(125, 30);
            this.close.TabIndex = 13;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(13, 184);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(125, 30);
            this.send.TabIndex = 14;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Receive
            // 
            this.Receive.AutoSize = true;
            this.Receive.Location = new System.Drawing.Point(13, 221);
            this.Receive.Name = "Receive";
            this.Receive.Size = new System.Drawing.Size(55, 15);
            this.Receive.TabIndex = 15;
            this.Receive.Text = "Receive:";
            // 
            // logtextbox
            // 
            this.logtextbox.Location = new System.Drawing.Point(786, 32);
            this.logtextbox.Multiline = true;
            this.logtextbox.Name = "logtextbox";
            this.logtextbox.Size = new System.Drawing.Size(547, 146);
            this.logtextbox.TabIndex = 16;
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.Location = new System.Drawing.Point(783, 13);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(34, 15);
            this.log.TabIndex = 17;
            this.log.Text = "Log:";
            // 
            // savelog
            // 
            this.savelog.Location = new System.Drawing.Point(1208, 184);
            this.savelog.Name = "savelog";
            this.savelog.Size = new System.Drawing.Size(125, 30);
            this.savelog.TabIndex = 18;
            this.savelog.Text = "Save Log";
            this.savelog.UseVisualStyleBackColor = true;
            this.savelog.Click += new System.EventHandler(this.Savelog_Click);
            // 
            // samplestart
            // 
            this.samplestart.Location = new System.Drawing.Point(652, 173);
            this.samplestart.Name = "samplestart";
            this.samplestart.Size = new System.Drawing.Size(62, 30);
            this.samplestart.TabIndex = 19;
            this.samplestart.Text = "Start";
            this.samplestart.UseVisualStyleBackColor = true;
            this.samplestart.Click += new System.EventHandler(this.Samplestart_Click);
            // 
            // setsamplerate
            // 
            this.setsamplerate.AutoSize = true;
            this.setsamplerate.Location = new System.Drawing.Point(649, 124);
            this.setsamplerate.Name = "setsamplerate";
            this.setsamplerate.Size = new System.Drawing.Size(130, 15);
            this.setsamplerate.TabIndex = 20;
            this.setsamplerate.Text = "Set Sample Rate(ms):";
            // 
            // sampleratetextbox
            // 
            this.sampleratetextbox.Location = new System.Drawing.Point(652, 142);
            this.sampleratetextbox.Name = "sampleratetextbox";
            this.sampleratetextbox.Size = new System.Drawing.Size(125, 25);
            this.sampleratetextbox.TabIndex = 21;
            // 
            // samplestop
            // 
            this.samplestop.Location = new System.Drawing.Point(715, 173);
            this.samplestop.Name = "samplestop";
            this.samplestop.Size = new System.Drawing.Size(62, 30);
            this.samplestop.TabIndex = 22;
            this.samplestop.Text = "Stop";
            this.samplestop.UseVisualStyleBackColor = true;
            this.samplestop.Click += new System.EventHandler(this.Samplestop_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(652, 239);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(125, 30);
            this.reset.TabIndex = 23;
            this.reset.Text = "Re-set";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // checkconn
            // 
            this.checkconn.Location = new System.Drawing.Point(652, 275);
            this.checkconn.Name = "checkconn";
            this.checkconn.Size = new System.Drawing.Size(125, 30);
            this.checkconn.TabIndex = 24;
            this.checkconn.Text = "Check Connection";
            this.checkconn.UseVisualStyleBackColor = true;
            this.checkconn.Click += new System.EventHandler(this.Checkconn_Click);
            // 
            // checkname
            // 
            this.checkname.Location = new System.Drawing.Point(652, 311);
            this.checkname.Name = "checkname";
            this.checkname.Size = new System.Drawing.Size(125, 30);
            this.checkname.TabIndex = 25;
            this.checkname.Text = "Check Name";
            this.checkname.UseVisualStyleBackColor = true;
            this.checkname.Click += new System.EventHandler(this.Checkname_Click);
            // 
            // getvalue
            // 
            this.getvalue.Location = new System.Drawing.Point(652, 347);
            this.getvalue.Name = "getvalue";
            this.getvalue.Size = new System.Drawing.Size(125, 30);
            this.getvalue.TabIndex = 26;
            this.getvalue.Text = "Get Value";
            this.getvalue.UseVisualStyleBackColor = true;
            this.getvalue.Click += new System.EventHandler(this.Getvalue_Click);
            // 
            // mod00
            // 
            this.mod00.Location = new System.Drawing.Point(652, 383);
            this.mod00.Name = "mod00";
            this.mod00.Size = new System.Drawing.Size(125, 30);
            this.mod00.TabIndex = 27;
            this.mod00.Text = "Set Mod00";
            this.mod00.UseVisualStyleBackColor = true;
            this.mod00.Click += new System.EventHandler(this.Mod00_Click);
            // 
            // mod10
            // 
            this.mod10.Location = new System.Drawing.Point(652, 419);
            this.mod10.Name = "mod10";
            this.mod10.Size = new System.Drawing.Size(125, 30);
            this.mod10.TabIndex = 28;
            this.mod10.Text = "Set Mod10";
            this.mod10.UseVisualStyleBackColor = true;
            this.mod10.Click += new System.EventHandler(this.Mod10_Click);
            // 
            // setparameters
            // 
            this.setparameters.Location = new System.Drawing.Point(652, 48);
            this.setparameters.Name = "setparameters";
            this.setparameters.Size = new System.Drawing.Size(125, 30);
            this.setparameters.TabIndex = 29;
            this.setparameters.Text = "Set Parameters";
            this.setparameters.UseVisualStyleBackColor = true;
            this.setparameters.Click += new System.EventHandler(this.Setparameters_Click);
            // 
            // labelchart
            // 
            this.labelchart.AutoSize = true;
            this.labelchart.Location = new System.Drawing.Point(786, 221);
            this.labelchart.Name = "labelchart";
            this.labelchart.Size = new System.Drawing.Size(42, 15);
            this.labelchart.TabIndex = 30;
            this.labelchart.Text = "Chart:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(789, 239);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Value";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(544, 321);
            this.chart1.TabIndex = 31;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 572);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.labelchart);
            this.Controls.Add(this.setparameters);
            this.Controls.Add(this.mod10);
            this.Controls.Add(this.mod00);
            this.Controls.Add(this.getvalue);
            this.Controls.Add(this.checkname);
            this.Controls.Add(this.checkconn);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.samplestop);
            this.Controls.Add(this.sampleratetextbox);
            this.Controls.Add(this.setsamplerate);
            this.Controls.Add(this.samplestart);
            this.Controls.Add(this.savelog);
            this.Controls.Add(this.log);
            this.Controls.Add(this.logtextbox);
            this.Controls.Add(this.Receive);
            this.Controls.Add(this.send);
            this.Controls.Add(this.close);
            this.Controls.Add(this.connect);
            this.Controls.Add(this.stopbitsc);
            this.Controls.Add(this.databitsc);
            this.Controls.Add(this.parityc);
            this.Controls.Add(this.baudratec);
            this.Controls.Add(this.portc);
            this.Controls.Add(this.Stopbits);
            this.Controls.Add(this.Databits);
            this.Controls.Add(this.Parity);
            this.Controls.Add(this.BaudRate);
            this.Controls.Add(this.Port);
            this.Controls.Add(this.sendtextbox);
            this.Controls.Add(this.receivetextbox);
            this.Name = "Form1";
            this.Text = "WGI-400A-02";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox receivetextbox;
        private System.Windows.Forms.TextBox sendtextbox;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.Label BaudRate;
        private System.Windows.Forms.Label Parity;
        private System.Windows.Forms.Label Databits;
        private System.Windows.Forms.Label Stopbits;
        private System.Windows.Forms.ComboBox portc;
        private System.Windows.Forms.ComboBox baudratec;
        private System.Windows.Forms.ComboBox parityc;
        private System.Windows.Forms.ComboBox databitsc;
        private System.Windows.Forms.ComboBox stopbitsc;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Label Receive;
        private System.Windows.Forms.TextBox logtextbox;
        private System.Windows.Forms.Label log;
        private System.Windows.Forms.Button savelog;
        private System.Windows.Forms.Button samplestart;
        private System.Windows.Forms.Label setsamplerate;
        private System.Windows.Forms.TextBox sampleratetextbox;
        private System.Windows.Forms.Button samplestop;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button checkconn;
        private System.Windows.Forms.Button checkname;
        private System.Windows.Forms.Button getvalue;
        private System.Windows.Forms.Button mod00;
        private System.Windows.Forms.Button mod10;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button setparameters;
        private System.Windows.Forms.Label labelchart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

