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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.MachineStatus = new System.Windows.Forms.GroupBox();
            this.textMachinePressure = new System.Windows.Forms.TextBox();
            this.highLightShown = new System.Windows.Forms.Label();
            this.buttonMachineStatusClose = new System.Windows.Forms.Button();
            this.buttonMinimumSetting = new System.Windows.Forms.Button();
            this.Statuslow = new System.Windows.Forms.Label();
            this.buttonMaximumSetting = new System.Windows.Forms.Button();
            this.Statusok = new System.Windows.Forms.Label();
            this.textMinimumSetting = new System.Windows.Forms.TextBox();
            this.Statushigh = new System.Windows.Forms.Label();
            this.textMaximumSetting = new System.Windows.Forms.TextBox();
            this.buttonMachineStatusStart = new System.Windows.Forms.Button();
            this.okLightShown = new System.Windows.Forms.Label();
            this.lowLightShown = new System.Windows.Forms.Label();
            this.Connection = new System.Windows.Forms.GroupBox();
            this.Command = new System.Windows.Forms.Label();
            this.SendandReceive = new System.Windows.Forms.GroupBox();
            this.sample = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.MachineStatus.SuspendLayout();
            this.Connection.SuspendLayout();
            this.SendandReceive.SuspendLayout();
            this.sample.SuspendLayout();
            this.SuspendLayout();
            // 
            // receivetextbox
            // 
            this.receivetextbox.Location = new System.Drawing.Point(9, 176);
            this.receivetextbox.Multiline = true;
            this.receivetextbox.Name = "receivetextbox";
            this.receivetextbox.Size = new System.Drawing.Size(423, 169);
            this.receivetextbox.TabIndex = 0;
            // 
            // sendtextbox
            // 
            this.sendtextbox.Location = new System.Drawing.Point(9, 39);
            this.sendtextbox.Multiline = true;
            this.sendtextbox.Name = "sendtextbox";
            this.sendtextbox.Size = new System.Drawing.Size(423, 82);
            this.sendtextbox.TabIndex = 1;
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Location = new System.Drawing.Point(5, 21);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(35, 15);
            this.Port.TabIndex = 2;
            this.Port.Text = "Port:";
            // 
            // BaudRate
            // 
            this.BaudRate.AutoSize = true;
            this.BaudRate.Location = new System.Drawing.Point(91, 21);
            this.BaudRate.Name = "BaudRate";
            this.BaudRate.Size = new System.Drawing.Size(69, 15);
            this.BaudRate.TabIndex = 3;
            this.BaudRate.Text = "Baud Rate:";
            // 
            // Parity
            // 
            this.Parity.AutoSize = true;
            this.Parity.Location = new System.Drawing.Point(177, 21);
            this.Parity.Name = "Parity";
            this.Parity.Size = new System.Drawing.Size(45, 15);
            this.Parity.TabIndex = 4;
            this.Parity.Text = "Parity:";
            // 
            // Databits
            // 
            this.Databits.AutoSize = true;
            this.Databits.Location = new System.Drawing.Point(263, 21);
            this.Databits.Name = "Databits";
            this.Databits.Size = new System.Drawing.Size(72, 15);
            this.Databits.TabIndex = 5;
            this.Databits.Text = "Datalength:";
            // 
            // Stopbits
            // 
            this.Stopbits.AutoSize = true;
            this.Stopbits.Location = new System.Drawing.Point(349, 21);
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
            this.portc.Location = new System.Drawing.Point(8, 39);
            this.portc.Name = "portc";
            this.portc.Size = new System.Drawing.Size(80, 23);
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
            this.baudratec.Location = new System.Drawing.Point(94, 39);
            this.baudratec.Name = "baudratec";
            this.baudratec.Size = new System.Drawing.Size(80, 23);
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
            this.parityc.Location = new System.Drawing.Point(180, 39);
            this.parityc.Name = "parityc";
            this.parityc.Size = new System.Drawing.Size(80, 23);
            this.parityc.TabIndex = 9;
            this.parityc.Text = "Odd";
            // 
            // databitsc
            // 
            this.databitsc.FormattingEnabled = true;
            this.databitsc.Items.AddRange(new object[] {
            "7",
            "8"});
            this.databitsc.Location = new System.Drawing.Point(266, 39);
            this.databitsc.Name = "databitsc";
            this.databitsc.Size = new System.Drawing.Size(80, 23);
            this.databitsc.TabIndex = 10;
            this.databitsc.Text = "7";
            // 
            // stopbitsc
            // 
            this.stopbitsc.FormattingEnabled = true;
            this.stopbitsc.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.stopbitsc.Location = new System.Drawing.Point(352, 39);
            this.stopbitsc.Name = "stopbitsc";
            this.stopbitsc.Size = new System.Drawing.Size(80, 23);
            this.stopbitsc.TabIndex = 11;
            this.stopbitsc.Text = "One";
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(4, 68);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(140, 30);
            this.connect.TabIndex = 12;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(150, 68);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(140, 30);
            this.close.TabIndex = 13;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(307, 127);
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
            this.Receive.Location = new System.Drawing.Point(6, 158);
            this.Receive.Name = "Receive";
            this.Receive.Size = new System.Drawing.Size(55, 15);
            this.Receive.TabIndex = 15;
            this.Receive.Text = "Receive:";
            // 
            // logtextbox
            // 
            this.logtextbox.Location = new System.Drawing.Point(680, 33);
            this.logtextbox.Multiline = true;
            this.logtextbox.Name = "logtextbox";
            this.logtextbox.Size = new System.Drawing.Size(496, 191);
            this.logtextbox.TabIndex = 16;
            // 
            // log
            // 
            this.log.AutoSize = true;
            this.log.Location = new System.Drawing.Point(677, 12);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(34, 15);
            this.log.TabIndex = 17;
            this.log.Text = "Log:";
            // 
            // savelog
            // 
            this.savelog.Location = new System.Drawing.Point(1052, 230);
            this.savelog.Name = "savelog";
            this.savelog.Size = new System.Drawing.Size(125, 30);
            this.savelog.TabIndex = 18;
            this.savelog.Text = "Save Log";
            this.savelog.UseVisualStyleBackColor = true;
            this.savelog.Click += new System.EventHandler(this.Savelog_Click);
            // 
            // samplestart
            // 
            this.samplestart.Location = new System.Drawing.Point(6, 70);
            this.samplestart.Name = "samplestart";
            this.samplestart.Size = new System.Drawing.Size(100, 30);
            this.samplestart.TabIndex = 19;
            this.samplestart.Text = "Start";
            this.samplestart.UseVisualStyleBackColor = true;
            this.samplestart.Click += new System.EventHandler(this.Samplestart_Click);
            // 
            // setsamplerate
            // 
            this.setsamplerate.AutoSize = true;
            this.setsamplerate.Location = new System.Drawing.Point(6, 21);
            this.setsamplerate.Name = "setsamplerate";
            this.setsamplerate.Size = new System.Drawing.Size(130, 15);
            this.setsamplerate.TabIndex = 20;
            this.setsamplerate.Text = "Set Sample Rate(ms):";
            // 
            // sampleratetextbox
            // 
            this.sampleratetextbox.Location = new System.Drawing.Point(6, 39);
            this.sampleratetextbox.Name = "sampleratetextbox";
            this.sampleratetextbox.Size = new System.Drawing.Size(201, 25);
            this.sampleratetextbox.TabIndex = 21;
            // 
            // samplestop
            // 
            this.samplestop.Location = new System.Drawing.Point(107, 70);
            this.samplestop.Name = "samplestop";
            this.samplestop.Size = new System.Drawing.Size(100, 30);
            this.samplestop.TabIndex = 22;
            this.samplestop.Text = "Stop";
            this.samplestop.UseVisualStyleBackColor = true;
            this.samplestop.Click += new System.EventHandler(this.Samplestop_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(4, 104);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(140, 30);
            this.reset.TabIndex = 23;
            this.reset.Text = "Re-set";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // checkconn
            // 
            this.checkconn.Location = new System.Drawing.Point(150, 104);
            this.checkconn.Name = "checkconn";
            this.checkconn.Size = new System.Drawing.Size(140, 30);
            this.checkconn.TabIndex = 24;
            this.checkconn.Text = "Check Connection";
            this.checkconn.UseVisualStyleBackColor = true;
            this.checkconn.Click += new System.EventHandler(this.Checkconn_Click);
            // 
            // checkname
            // 
            this.checkname.Location = new System.Drawing.Point(296, 104);
            this.checkname.Name = "checkname";
            this.checkname.Size = new System.Drawing.Size(140, 30);
            this.checkname.TabIndex = 25;
            this.checkname.Text = "Check Name";
            this.checkname.UseVisualStyleBackColor = true;
            this.checkname.Click += new System.EventHandler(this.Checkname_Click);
            // 
            // getvalue
            // 
            this.getvalue.Location = new System.Drawing.Point(4, 140);
            this.getvalue.Name = "getvalue";
            this.getvalue.Size = new System.Drawing.Size(140, 30);
            this.getvalue.TabIndex = 26;
            this.getvalue.Text = "Get Value";
            this.getvalue.UseVisualStyleBackColor = true;
            this.getvalue.Click += new System.EventHandler(this.Getvalue_Click);
            // 
            // mod00
            // 
            this.mod00.Location = new System.Drawing.Point(150, 140);
            this.mod00.Name = "mod00";
            this.mod00.Size = new System.Drawing.Size(140, 30);
            this.mod00.TabIndex = 27;
            this.mod00.Text = "Set Mod00";
            this.mod00.UseVisualStyleBackColor = true;
            this.mod00.Click += new System.EventHandler(this.Mod00_Click);
            // 
            // mod10
            // 
            this.mod10.Location = new System.Drawing.Point(296, 140);
            this.mod10.Name = "mod10";
            this.mod10.Size = new System.Drawing.Size(140, 30);
            this.mod10.TabIndex = 28;
            this.mod10.Text = "Set Mod10";
            this.mod10.UseVisualStyleBackColor = true;
            this.mod10.Click += new System.EventHandler(this.Mod10_Click);
            // 
            // setparameters
            // 
            this.setparameters.Location = new System.Drawing.Point(296, 68);
            this.setparameters.Name = "setparameters";
            this.setparameters.Size = new System.Drawing.Size(140, 30);
            this.setparameters.TabIndex = 29;
            this.setparameters.Text = "Set Parameters";
            this.setparameters.UseVisualStyleBackColor = true;
            this.setparameters.Click += new System.EventHandler(this.Setparameters_Click);
            // 
            // labelchart
            // 
            this.labelchart.AutoSize = true;
            this.labelchart.Location = new System.Drawing.Point(677, 274);
            this.labelchart.Name = "labelchart";
            this.labelchart.Size = new System.Drawing.Size(42, 15);
            this.labelchart.TabIndex = 30;
            this.labelchart.Text = "Chart:";
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(680, 293);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Value";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(497, 267);
            this.chart1.TabIndex = 31;
            this.chart1.Text = "chart1";
            // 
            // MachineStatus
            // 
            this.MachineStatus.Controls.Add(this.textMachinePressure);
            this.MachineStatus.Controls.Add(this.highLightShown);
            this.MachineStatus.Controls.Add(this.buttonMachineStatusClose);
            this.MachineStatus.Controls.Add(this.buttonMinimumSetting);
            this.MachineStatus.Controls.Add(this.Statuslow);
            this.MachineStatus.Controls.Add(this.buttonMaximumSetting);
            this.MachineStatus.Controls.Add(this.Statusok);
            this.MachineStatus.Controls.Add(this.textMinimumSetting);
            this.MachineStatus.Controls.Add(this.Statushigh);
            this.MachineStatus.Controls.Add(this.textMaximumSetting);
            this.MachineStatus.Controls.Add(this.buttonMachineStatusStart);
            this.MachineStatus.Controls.Add(this.okLightShown);
            this.MachineStatus.Controls.Add(this.lowLightShown);
            this.MachineStatus.Location = new System.Drawing.Point(458, 189);
            this.MachineStatus.Name = "MachineStatus";
            this.MachineStatus.Size = new System.Drawing.Size(213, 371);
            this.MachineStatus.TabIndex = 46;
            this.MachineStatus.TabStop = false;
            this.MachineStatus.Text = "Machine Status";
            // 
            // textMachinePressure
            // 
            this.textMachinePressure.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textMachinePressure.Location = new System.Drawing.Point(22, 173);
            this.textMachinePressure.Multiline = true;
            this.textMachinePressure.Name = "textMachinePressure";
            this.textMachinePressure.Size = new System.Drawing.Size(169, 40);
            this.textMachinePressure.TabIndex = 45;
            this.textMachinePressure.Text = "0";
            this.textMachinePressure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // highLightShown
            // 
            this.highLightShown.AutoSize = true;
            this.highLightShown.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.highLightShown.Location = new System.Drawing.Point(100, 25);
            this.highLightShown.Name = "highLightShown";
            this.highLightShown.Size = new System.Drawing.Size(49, 34);
            this.highLightShown.TabIndex = 37;
            this.highLightShown.Text = "●";
            // 
            // buttonMachineStatusClose
            // 
            this.buttonMachineStatusClose.Location = new System.Drawing.Point(6, 334);
            this.buttonMachineStatusClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMachineStatusClose.Name = "buttonMachineStatusClose";
            this.buttonMachineStatusClose.Size = new System.Drawing.Size(201, 30);
            this.buttonMachineStatusClose.TabIndex = 44;
            this.buttonMachineStatusClose.Text = "Stop Monitor";
            this.buttonMachineStatusClose.UseVisualStyleBackColor = true;
            this.buttonMachineStatusClose.Click += new System.EventHandler(this.ButtonMachineStatusClose_Click);
            // 
            // buttonMinimumSetting
            // 
            this.buttonMinimumSetting.Location = new System.Drawing.Point(107, 232);
            this.buttonMinimumSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMinimumSetting.Name = "buttonMinimumSetting";
            this.buttonMinimumSetting.Size = new System.Drawing.Size(100, 30);
            this.buttonMinimumSetting.TabIndex = 28;
            this.buttonMinimumSetting.Text = "Set MIN";
            this.buttonMinimumSetting.UseVisualStyleBackColor = true;
            this.buttonMinimumSetting.Click += new System.EventHandler(this.ButtonMinimumSetting_Click);
            // 
            // Statuslow
            // 
            this.Statuslow.AutoSize = true;
            this.Statuslow.Location = new System.Drawing.Point(60, 135);
            this.Statuslow.Name = "Statuslow";
            this.Statuslow.Size = new System.Drawing.Size(33, 15);
            this.Statuslow.TabIndex = 43;
            this.Statuslow.Text = "Low";
            // 
            // buttonMaximumSetting
            // 
            this.buttonMaximumSetting.Location = new System.Drawing.Point(107, 266);
            this.buttonMaximumSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMaximumSetting.Name = "buttonMaximumSetting";
            this.buttonMaximumSetting.Size = new System.Drawing.Size(100, 30);
            this.buttonMaximumSetting.TabIndex = 29;
            this.buttonMaximumSetting.Text = "Set MAX";
            this.buttonMaximumSetting.UseVisualStyleBackColor = true;
            this.buttonMaximumSetting.Click += new System.EventHandler(this.ButtonMaximumSetting_Click);
            // 
            // Statusok
            // 
            this.Statusok.AutoSize = true;
            this.Statusok.Location = new System.Drawing.Point(60, 85);
            this.Statusok.Name = "Statusok";
            this.Statusok.Size = new System.Drawing.Size(27, 15);
            this.Statusok.TabIndex = 42;
            this.Statusok.Text = "OK";
            // 
            // textMinimumSetting
            // 
            this.textMinimumSetting.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textMinimumSetting.Location = new System.Drawing.Point(6, 232);
            this.textMinimumSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textMinimumSetting.Multiline = true;
            this.textMinimumSetting.Name = "textMinimumSetting";
            this.textMinimumSetting.Size = new System.Drawing.Size(100, 30);
            this.textMinimumSetting.TabIndex = 30;
            this.textMinimumSetting.Text = "0";
            // 
            // Statushigh
            // 
            this.Statushigh.AutoSize = true;
            this.Statushigh.Location = new System.Drawing.Point(60, 35);
            this.Statushigh.Name = "Statushigh";
            this.Statushigh.Size = new System.Drawing.Size(35, 15);
            this.Statushigh.TabIndex = 41;
            this.Statushigh.Text = "High";
            // 
            // textMaximumSetting
            // 
            this.textMaximumSetting.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textMaximumSetting.Location = new System.Drawing.Point(6, 266);
            this.textMaximumSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textMaximumSetting.Multiline = true;
            this.textMaximumSetting.Name = "textMaximumSetting";
            this.textMaximumSetting.Size = new System.Drawing.Size(100, 30);
            this.textMaximumSetting.TabIndex = 31;
            this.textMaximumSetting.Text = "0";
            // 
            // buttonMachineStatusStart
            // 
            this.buttonMachineStatusStart.Location = new System.Drawing.Point(6, 300);
            this.buttonMachineStatusStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMachineStatusStart.Name = "buttonMachineStatusStart";
            this.buttonMachineStatusStart.Size = new System.Drawing.Size(201, 30);
            this.buttonMachineStatusStart.TabIndex = 40;
            this.buttonMachineStatusStart.Text = "Start Monitor";
            this.buttonMachineStatusStart.UseVisualStyleBackColor = true;
            this.buttonMachineStatusStart.Click += new System.EventHandler(this.ButtonMachineStatusStart_Click);
            // 
            // okLightShown
            // 
            this.okLightShown.AutoSize = true;
            this.okLightShown.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.okLightShown.Location = new System.Drawing.Point(100, 75);
            this.okLightShown.Name = "okLightShown";
            this.okLightShown.Size = new System.Drawing.Size(49, 34);
            this.okLightShown.TabIndex = 38;
            this.okLightShown.Text = "●";
            // 
            // lowLightShown
            // 
            this.lowLightShown.AutoSize = true;
            this.lowLightShown.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lowLightShown.Location = new System.Drawing.Point(100, 125);
            this.lowLightShown.Name = "lowLightShown";
            this.lowLightShown.Size = new System.Drawing.Size(49, 34);
            this.lowLightShown.TabIndex = 39;
            this.lowLightShown.Text = "●";
            // 
            // Connection
            // 
            this.Connection.Controls.Add(this.portc);
            this.Connection.Controls.Add(this.baudratec);
            this.Connection.Controls.Add(this.Port);
            this.Connection.Controls.Add(this.parityc);
            this.Connection.Controls.Add(this.setparameters);
            this.Connection.Controls.Add(this.databitsc);
            this.Connection.Controls.Add(this.mod10);
            this.Connection.Controls.Add(this.stopbitsc);
            this.Connection.Controls.Add(this.mod00);
            this.Connection.Controls.Add(this.BaudRate);
            this.Connection.Controls.Add(this.getvalue);
            this.Connection.Controls.Add(this.Parity);
            this.Connection.Controls.Add(this.checkname);
            this.Connection.Controls.Add(this.Databits);
            this.Connection.Controls.Add(this.checkconn);
            this.Connection.Controls.Add(this.Stopbits);
            this.Connection.Controls.Add(this.reset);
            this.Connection.Controls.Add(this.connect);
            this.Connection.Controls.Add(this.close);
            this.Connection.Location = new System.Drawing.Point(12, 12);
            this.Connection.Name = "Connection";
            this.Connection.Size = new System.Drawing.Size(440, 191);
            this.Connection.TabIndex = 47;
            this.Connection.TabStop = false;
            this.Connection.Text = "Connection";
            // 
            // Command
            // 
            this.Command.AutoSize = true;
            this.Command.Location = new System.Drawing.Point(6, 21);
            this.Command.Name = "Command";
            this.Command.Size = new System.Drawing.Size(69, 15);
            this.Command.TabIndex = 48;
            this.Command.Text = "Command:";
            // 
            // SendandReceive
            // 
            this.SendandReceive.Controls.Add(this.Command);
            this.SendandReceive.Controls.Add(this.sendtextbox);
            this.SendandReceive.Controls.Add(this.send);
            this.SendandReceive.Controls.Add(this.Receive);
            this.SendandReceive.Controls.Add(this.receivetextbox);
            this.SendandReceive.Location = new System.Drawing.Point(12, 209);
            this.SendandReceive.Name = "SendandReceive";
            this.SendandReceive.Size = new System.Drawing.Size(440, 351);
            this.SendandReceive.TabIndex = 49;
            this.SendandReceive.TabStop = false;
            this.SendandReceive.Text = "Send and Receive";
            // 
            // sample
            // 
            this.sample.Controls.Add(this.setsamplerate);
            this.sample.Controls.Add(this.samplestart);
            this.sample.Controls.Add(this.sampleratetextbox);
            this.sample.Controls.Add(this.samplestop);
            this.sample.Location = new System.Drawing.Point(458, 12);
            this.sample.Name = "sample";
            this.sample.Size = new System.Drawing.Size(213, 110);
            this.sample.TabIndex = 50;
            this.sample.TabStop = false;
            this.sample.Text = "Sampling";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 572);
            this.Controls.Add(this.sample);
            this.Controls.Add(this.SendandReceive);
            this.Controls.Add(this.Connection);
            this.Controls.Add(this.MachineStatus);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.labelchart);
            this.Controls.Add(this.savelog);
            this.Controls.Add(this.log);
            this.Controls.Add(this.logtextbox);
            this.Name = "Form1";
            this.Text = "WGI-400A-02";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.MachineStatus.ResumeLayout(false);
            this.MachineStatus.PerformLayout();
            this.Connection.ResumeLayout(false);
            this.Connection.PerformLayout();
            this.SendandReceive.ResumeLayout(false);
            this.SendandReceive.PerformLayout();
            this.sample.ResumeLayout(false);
            this.sample.PerformLayout();
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
        private System.Windows.Forms.GroupBox MachineStatus;
        private System.Windows.Forms.TextBox textMachinePressure;
        private System.Windows.Forms.Label highLightShown;
        private System.Windows.Forms.Button buttonMachineStatusClose;
        private System.Windows.Forms.Button buttonMinimumSetting;
        private System.Windows.Forms.Label Statuslow;
        private System.Windows.Forms.Button buttonMaximumSetting;
        private System.Windows.Forms.Label Statusok;
        private System.Windows.Forms.TextBox textMinimumSetting;
        private System.Windows.Forms.Label Statushigh;
        private System.Windows.Forms.TextBox textMaximumSetting;
        private System.Windows.Forms.Button buttonMachineStatusStart;
        private System.Windows.Forms.Label okLightShown;
        private System.Windows.Forms.Label lowLightShown;
        private System.Windows.Forms.GroupBox Connection;
        private System.Windows.Forms.Label Command;
        private System.Windows.Forms.GroupBox SendandReceive;
        private System.Windows.Forms.GroupBox sample;
    }
}

