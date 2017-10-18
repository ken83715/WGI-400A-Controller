using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WGI_400A
{
    public partial class Form1 : Form
    {
        //Status 0: Common
        //Status 1: Sampling
        //Status 2: Sampling with Light
        //Status 3: Calibrate
        public int Status;

        //is sampling or not
        public bool Sampling;

        //sample rate (ms)
        public int Samplerate;        

        //pressure high bound
        public int Hbound;

        public bool HboundSet;

        //pressure low bound
        public int Lbound;

        public bool LboundSet;

        //chart max value
        public int ChartMax;

        //pressure limit
        public int MachineSafePressure;

        //calibrate offset
        public int CalibOffset;

        //message
        public string Message = "Message";

        //init
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();

            Status = 0;

            Sampling = false;

            Hbound = 0;
            Lbound = 0;
            HboundSet = false;
            LboundSet = false;

            ChartMax = 100;

            MachineSafePressure = 1000;

            CalibOffset = 0;

            buttonMachineStatusStart.Enabled = false;

            foreach (string ports in SerialPort.GetPortNames())
            {
                portc.Items.Add(ports);
            }            
        }

        //Connection Function
        public void SerialPortConnect(string port, int baudrate, Parity parity, int databits, StopBits stopbits)
        {
            DateTime dateTime = DateTime.Now;
            string dateTimeNow = dateTime.ToShortTimeString();

            serialPort1 = new SerialPort(port, baudrate, parity, databits, stopbits);

            try
            {
                serialPort1.Open();                
                serialPort1.DataReceived += DataReceivedHandler;

                logtextbox.AppendText("[" + dateTimeNow + "] " + port + " Connected" + "\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Draw Chart
        private void Draw_chart(int getValue)
        {
            Series s = chart1.Series["Value"];
            //Determine the next X value
            double nextX = 1;

            if (s.Points.Count > 0)
            {
                nextX = s.Points[s.Points.Count - 1].XValue + 1;
            }

            //Add a new value to the Series
            s.Points.AddXY(nextX, getValue);

            //Remove Points on the left side after 100
            while (s.Points.Count > 100)
            {
                s.Points.RemoveAt(0);
            }

            //Keep Xaxis and Yaxis at 0 to 100
            ChartMax = 100;
            for (int i = 0; i < s.Points.Count; i++)
            {
                s.Points[i].XValue = i;
                if (s.Points[i].YValues[0] > ChartMax)
                    ChartMax = Convert.ToInt32(s.Points[i].YValues[0]);
            }

            //Set Border
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Maximum = 100;
            chart1.ChartAreas[0].AxisY.Minimum = 0;
            chart1.ChartAreas[0].AxisY.Maximum = ChartMax;
        }

        //Sampling
        private void Portsampling()
        {
            try
            {
                while (Sampling)
                {
                    // "\r\n"為Windows換行
                    serialPort1.Write("GDT1\r\n");
                    Thread.Sleep(Samplerate);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Set The Light
        private void SetLight(int pre)
        {
            if (serialPort1.IsOpen)
            {
                if (pre > Hbound)
                {
                    highLightShown.ForeColor = Color.Red;
                    okLightShown.ForeColor = Color.Black;
                    lowLightShown.ForeColor = Color.Black;
                }
                else if (pre < Lbound)
                {
                    highLightShown.ForeColor = Color.Black;
                    okLightShown.ForeColor = Color.Black;
                    lowLightShown.ForeColor = Color.Red;
                }
                else
                {
                    highLightShown.ForeColor = Color.Black;
                    okLightShown.ForeColor = Color.Green;
                    lowLightShown.ForeColor = Color.Black;
                }               
            }
        }

        //DataReceivedHandler
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            if (Status == 0)
            {
                DateTime dateTime = DateTime.Now;
                string dateTimeNow = dateTime.ToShortTimeString();

                string indata = serialPort1.ReadExisting();

                Console.WriteLine(indata);

                receivetextbox.AppendText(indata + "\n");

                logtextbox.AppendText("[" + dateTimeNow + "]" + " Received: " + indata + "\n");
            }
            else if (Status == 1)
            {
                DateTime dateTime = DateTime.Now;
                string dateTimeNow = dateTime.ToShortTimeString();

                string indata = serialPort1.ReadExisting();
                if (indata.Length == 10)
                {
                    Console.WriteLine(indata);

                    receivetextbox.AppendText(indata + "\n");

                    string pressure = indata.Substring(3, 5);
                    int pressureint = Convert.ToInt32(pressure) + CalibOffset;
                    textMachinePressure.AppendText(pressureint.ToString() + "\n");
                    Draw_chart(pressureint);

                    //pressure exceed the limit
                    string errormessage = "Pressure Exceed the Limit !";
                    if (Convert.ToInt32(pressure) > MachineSafePressure)
                    {
                        MessageBox.Show(errormessage);
                    }
                }

                logtextbox.AppendText("[" + dateTimeNow + "]" + " Received: " + indata + "\n");
            }
            else if (Status == 2)
            {
                DateTime dateTime = DateTime.Now;
                string dateTimeNow = dateTime.ToShortTimeString();

                string indata = serialPort1.ReadExisting();
                if (indata.Length == 10)
                {
                    Console.WriteLine(indata);

                    receivetextbox.AppendText(indata + "\n");

                    string pressure = indata.Substring(3, 5);
                    int pressureint = Convert.ToInt32(pressure) + CalibOffset;
                    SetLight(pressureint);
                    textMachinePressure.AppendText(pressureint.ToString() + "\n");
                    Draw_chart(pressureint);

                    //pressure exceed the limit
                    //no offset use on limit
                    string errormessage = "Pressure Exceed the Limit !";
                    if (Convert.ToInt32(pressure) > MachineSafePressure)
                    {
                        MessageBox.Show(errormessage);
                    }
                }

                logtextbox.AppendText("[" + dateTimeNow + "]" + " Received: " + indata + "\n");
            }            
        }
        
        #region button_area

        private void Connect_Click(object sender, EventArgs e)
        {
            string NULL = "null";
            if (Port.Text != NULL)
            {
                string port = portc.Text;
                int baudrate = Convert.ToInt32(baudratec.Text);
                Parity parity = (Parity)Enum.Parse(typeof(Parity), parityc.Text);
                int databits = Convert.ToInt32(databitsc.Text);
                StopBits stopbits = (StopBits)Enum.Parse(typeof(StopBits), stopbitsc.Text);

                SerialPortConnect(port, baudrate, parity, databits, stopbits);

                if (serialPort1.IsOpen)
                {
                    connect.Enabled = false;                   
                }
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            string dateTimeNow = dateTime.ToShortTimeString();

            try
            {
                if (serialPort1.IsOpen)
                {
                    Status = 0;
                    Sampling = false;
                    Samplerate = 0;

                    MachineSafePressure = 1000;

                    Hbound = 0;
                    HboundSet = false;
                    Lbound = 0;
                    LboundSet = false;

                    serialPort1.DataReceived -= DataReceivedHandler;
                    serialPort1.Close();

                    buttonMachineStatusStart.Enabled = false;
                    connect.Enabled = true;
                    
                    logtextbox.AppendText("[" + dateTimeNow + "]" + " Disconnected\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Setparameters_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    DateTime dateTime = DateTime.Now;
                    string dateTimeNow = dateTime.ToShortTimeString();

                    //this function based on kyowa WGI-400A machine

                    int baudrate = Convert.ToInt32(baudratec.Text);
                    string bdrate = "0";
                    switch (baudrate)
                    {
                        case 2400:
                            bdrate = "0";
                            break;
                        case 4800:
                            bdrate = "1";
                            break;
                        case 9600:
                            bdrate = "2";
                            break;
                        case 19200:
                            bdrate = "3";
                            break;
                        case 38400:
                            bdrate = "4";
                            break;
                    }

                    string receivedeli = "1";
                    string senddeli = "0";

                    string databt = "0";
                    switch (databitsc.Text)
                    {
                        case "7":
                            databt = "0";
                            break;
                        case "8":
                            databt = "1";
                            break;                       
                    }

                    string paritybt = "0";
                    switch (parityc.Text)
                    {
                        case "None":
                            paritybt = "0";
                            break;
                        case "Odd":
                            paritybt = "1";
                            break;
                        case "Even":
                            paritybt = "2";
                            break;
                    }

                    string stopbt = "0";
                    
                    switch (stopbitsc.Text)
                    {
                        case "One":
                            stopbt = "1";
                            break;
                        case "Two":
                            stopbt = "0";
                            break;
                    }

                    string commandData = "SRS" + bdrate + "," + receivedeli + "," + senddeli + "," + databt + "," + paritybt + "," + stopbt + "\r\n";
                    
                    serialPort1.Write(commandData + "\r\n");

                    logtextbox.AppendText("[" + dateTimeNow + "]" + " Sent: " + commandData + "\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }    

        private void Reset_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    DateTime dateTime = DateTime.Now;
                    string dateTimeNow = dateTime.ToShortTimeString();
                    string commandData = "RES";

                    serialPort1.Write(commandData + "\r\n");

                    logtextbox.AppendText("[" + dateTimeNow + "]" + " Sent:" + commandData + "\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Checkconn_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    DateTime dateTime = DateTime.Now;
                    string dateTimeNow = dateTime.ToShortTimeString();
                    string commandData = "RS-";

                    serialPort1.Write(commandData + "\r\n");

                    logtextbox.AppendText("[" + dateTimeNow + "]" + " Sent:" + commandData + "\n");                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Checkname_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    DateTime dateTime = DateTime.Now;
                    string dateTimeNow = dateTime.ToShortTimeString();
                    string commandData = "SYS";

                    serialPort1.Write(commandData + "\r\n");

                    logtextbox.AppendText("[" + dateTimeNow + "]" + " Sent:" + commandData + "\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Getvalue_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    DateTime dateTime = DateTime.Now;
                    string dateTimeNow = dateTime.ToShortTimeString();
                    string commandData = "GDT1";

                    serialPort1.Write(commandData + "\r\n");

                    logtextbox.AppendText("[" + dateTimeNow + "]" + " Sent:" + commandData + "\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Mod00_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    DateTime dateTime = DateTime.Now;
                    string dateTimeNow = dateTime.ToShortTimeString();
                    string commandData = "MOD00";

                    Status = 1;
                    calib.Enabled = false;

                    serialPort1.Write(commandData + "\r\n");

                    logtextbox.AppendText("[" + dateTimeNow + "]" + " Sent:" + commandData + "\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Mod10_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    DateTime dateTime = DateTime.Now;
                    string dateTimeNow = dateTime.ToShortTimeString();
                    string commandData = "MOD10";

                    serialPort1.Write(commandData + "\r\n");

                    logtextbox.AppendText("[" + dateTimeNow + "]" + " Sent:" + commandData + "\n");

                    Status = 0;
                    calib.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Calib_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {                    
                    DateTime dateTime = DateTime.Now;
                    string dateTimeNow = dateTime.ToShortTimeString();

                    string calibnum = calibnumber.Text;
                    int num = Convert.ToInt32(calibnum);

                    CalibOffset = num;

                    logtextbox.AppendText("[" + dateTimeNow + "]" + " Calibrate" + "\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Send_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    DateTime dateTime = DateTime.Now;
                    string dateTimeNow = dateTime.ToShortTimeString();
                    string commandData = sendtextbox.Text;
              
                    serialPort1.Write(commandData + "\r\n");
                    sendtextbox.Clear();

                    logtextbox.AppendText("[" + dateTimeNow + "]" + " Sent: " + commandData + "\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Setlimit_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    DateTime dateTime = DateTime.Now;
                    string dateTimeNow = dateTime.ToShortTimeString();
                    string pressurelimit = plimit.Text;

                    MachineSafePressure = Convert.ToInt32(pressurelimit);

                    logtextbox.AppendText("[" + dateTimeNow + "]" + " Set pressure limit to " + pressurelimit + "\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Samplestart_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    DateTime dateTime = DateTime.Now;
                    string dateTimeNow = dateTime.ToShortTimeString();
                    Sampling = true;
                    samplestart.Enabled = false;
                    calib.Enabled = false;

                    Samplerate = Convert.ToInt32(sampleratetextbox.Text);

                    Status = 1;                   

                    Thread comThread = new Thread(Portsampling);
                    comThread.Start();

                    logtextbox.AppendText("[" + dateTimeNow + "]" + " Start Sampling\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Samplestop_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    DateTime dateTime = DateTime.Now;
                    string dateTimeNow = dateTime.ToShortTimeString();
                    Sampling = false;
                    samplestart.Enabled = true;
                    calib.Enabled = true;
                    textMachinePressure.Clear();

                    Status = 0;                   

                    logtextbox.AppendText("[" + dateTimeNow + "]" + " Stop Sampling\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonMinimumSetting_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                DateTime dateTime = DateTime.Now;
                string dateTimeNow = dateTime.ToShortTimeString();
                string commandData = "SCV2,+";
                string commandValue = textMinimumSetting.Text.PadLeft(5, '0');

                serialPort1.Write(commandData + commandValue + "\r\n");

                Lbound = Convert.ToInt32(commandValue);
                LboundSet = true;
                if (HboundSet && LboundSet)
                {
                    buttonMachineStatusStart.Enabled = true;
                }

                logtextbox.AppendText("[" + dateTimeNow + "]" + " Sent:" + commandData + commandValue + "\n");              
            }
        }

        private void ButtonMaximumSetting_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                DateTime dateTime = DateTime.Now;
                string dateTimeNow = dateTime.ToShortTimeString();
                string commandData = "SCV1,+";
                string commandValue = textMaximumSetting.Text.PadLeft(5, '0');

                serialPort1.Write(commandData + commandValue + "\r\n");

                Hbound = Convert.ToInt32(commandValue);
                HboundSet = true;
                if (HboundSet && LboundSet)
                {
                    buttonMachineStatusStart.Enabled = true;
                }

                logtextbox.AppendText("[" + dateTimeNow + "]" + " Sent:" + commandData + commandValue + "\n");               
            }
        }

        private void ButtonMachineStatusStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    textMinimumSetting.Enabled = false;
                    textMaximumSetting.Enabled = false;
                    buttonMinimumSetting.Enabled = false;
                    buttonMaximumSetting.Enabled = false;
                    
                    buttonMachineStatusStart.Enabled = false;
                    calib.Enabled = false;

                    Status = 2;                   

                    Sampling = true;
                    Thread machineStatusThread = new Thread(Portsampling);
                    machineStatusThread.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonMachineStatusClose_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    textMinimumSetting.Enabled = true;
                    textMaximumSetting.Enabled = true;
                    buttonMinimumSetting.Enabled = true;
                    buttonMaximumSetting.Enabled = true;

                    Sampling = false;
                    buttonMachineStatusStart.Enabled = true;
                    calib.Enabled = true;
                    textMachinePressure.Clear();

                    highLightShown.ForeColor = Color.Black;
                    okLightShown.ForeColor = Color.Black;
                    lowLightShown.ForeColor = Color.Black;

                    Status = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Savelog_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            string dateTimeNow = dateTime.ToString(CultureInfo.CurrentCulture).Replace(":", " ").Replace("/", "");
            //log file
            StreamWriter sw = new StreamWriter(@dateTimeNow + ".txt");
            sw.Write(logtextbox.Text);
            sw.Close();
            logtextbox.Clear();
        }

        #endregion

        
    }
}