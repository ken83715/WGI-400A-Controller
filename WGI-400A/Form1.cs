using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WGI_400A
{
    public partial class Form1 : Form
    {
        //is sampling or not
        public bool sampling = false;

        //sample rate (ms)
        public int samplerate = 0;

        //init
        public Form1()
        {
            Form1.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();

            foreach (String ports in SerialPort.GetPortNames())
            {
                portc.Items.Add(ports);
            }
        }

        //Connection function
        public void SerialPortConnect(String port, int baudrate, Parity parity, int databits, StopBits stopbits)
        {
            DateTime dateTime = DateTime.Now;
            String dateTimeNow = dateTime.ToShortTimeString();

            serialPort1 = new SerialPort(port, baudrate, parity, databits, stopbits);

            try
            {
                serialPort1.Open();
                logtextbox.AppendText("[" + dateTimeNow + "] " + port + " Connected\n");
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Draw Chart
        private void Draw_chart(int get_value)
        {
            Series s = chart1.Series["Value"];
            //Determine the next X value
            double nextX = 1;

            if (s.Points.Count > 0)
            {
                nextX = s.Points[s.Points.Count - 1].XValue + 1;
            }

            //Add a new value to the Series
            s.Points.AddXY(nextX, get_value);

            //Remove Points on the left side after 100
            while (s.Points.Count > 100)
            {
                s.Points.RemoveAt(0);
            }

            //Set the Minimum and Maximum values for the X Axis on the Chart
            double min = s.Points[0].XValue;
            chart1.ChartAreas[0].AxisX.Minimum = min;
            chart1.ChartAreas[0].AxisX.Maximum = min + 100;
        }

        //DataReceivedHandler
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            String dateTimeNow = dateTime.ToShortTimeString();

            string indata = serialPort1.ReadExisting();
            Console.WriteLine(indata);
            string s = indata.Substring(3, 5);
            Draw_chart(Convert.ToInt32(s));

            logtextbox.AppendText("[" + dateTimeNow + "]" + " Received: " + indata + "\n");
            receivetextbox.AppendText(indata + "\n");
        }

        //Sampling
        private void Portsampling()
        {
            try
            {
                while (sampling)
                {
                    serialPort1.Write("GDT1\r\n");
                    Thread.Sleep(samplerate);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region button_area

        private void Connect_Click(object sender, EventArgs e)
        {
            if (Port.Text != "null")
            {
                String port = portc.Text;
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
                    String dateTimeNow = dateTime.ToShortTimeString();

                    try
                    {
                        if (serialPort1.IsOpen)
                        {
                            serialPort1.DataReceived -= new SerialDataReceivedEventHandler(DataReceivedHandler);
                            serialPort1.Close();
                    
                            connect.Enabled = true;
                    
                            logtextbox.AppendText("[" + dateTimeNow + "]" + " Disconnected\n");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

        private void Setparameters_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    DateTime dateTime = DateTime.Now;
                    String dateTimeNow = dateTime.ToShortTimeString();

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

                    String commandData = "SRS" + bdrate + "," + receivedeli + "," + senddeli + "," + databt + "," + paritybt + "," + stopbt + "\r\n";

                    logtextbox.AppendText("[" + dateTimeNow + "]" + " Sent: " + commandData + "\n");
                    serialPort1.Write(commandData + "\r\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }    

        private void Reset_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    DateTime dateTime = DateTime.Now;
                    String dateTimeNow = dateTime.ToShortTimeString();
                    String commandData = "RES";

                    // "\r\n"為Windows換行
                    serialPort1.Write(commandData + "\r\n");

                    logtextbox.AppendText("[" + dateTimeNow + "]" + " Sent:" + commandData + "\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void Checkconn_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    DateTime dateTime = DateTime.Now;
                    String dateTimeNow = dateTime.ToShortTimeString();
                    String commandData = "RS-";

                    // "\r\n"為Windows換行
                    serialPort1.Write(commandData + "\r\n");

                    logtextbox.AppendText("[" + dateTimeNow + "]" + " Sent:" + commandData + "\n");                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Checkname_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    DateTime dateTime = DateTime.Now;
                    String dateTimeNow = dateTime.ToShortTimeString();
                    String commandData = "SYS";

                    // "\r\n"為Windows換行
                    serialPort1.Write(commandData + "\r\n");

                    logtextbox.AppendText("[" + dateTimeNow + "]" + " Sent:" + commandData + "\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Getvalue_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    DateTime dateTime = DateTime.Now;
                    String dateTimeNow = dateTime.ToShortTimeString();
                    String commandData = "GDT1";

                    // "\r\n"為Windows換行
                    serialPort1.Write(commandData + "\r\n");

                    logtextbox.AppendText("[" + dateTimeNow + "]" + " Sent:" + commandData + "\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Mod00_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    DateTime dateTime = DateTime.Now;
                    String dateTimeNow = dateTime.ToShortTimeString();
                    String commandData = "MOD00";

                    // "\r\n"為Windows換行
                    serialPort1.Write(commandData + "\r\n");

                    logtextbox.AppendText("[" + dateTimeNow + "]" + " Sent:" + commandData + "\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Mod10_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    DateTime dateTime = DateTime.Now;
                    String dateTimeNow = dateTime.ToShortTimeString();
                    String commandData = "MOD10";

                    // "\r\n"為Windows換行
                    serialPort1.Write(commandData + "\r\n");

                    logtextbox.AppendText("[" + dateTimeNow + "]" + " Sent:" + commandData + "\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Send_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    DateTime dateTime = DateTime.Now;
                    String dateTimeNow = dateTime.ToShortTimeString();
                    String commandData = sendtextbox.Text;

                    //"\r\n"為Windows換行
                    logtextbox.AppendText("[" + dateTimeNow + "]" + " Sent: " + commandData + "\n");
                    serialPort1.Write(commandData + "\r\n");
                    sendtextbox.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Samplestart_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    sampling = true;
                    samplestart.Enabled = false;
                    samplerate = Convert.ToInt32(sampleratetextbox.Text);
                    Thread comThread = new Thread(Portsampling);
                    comThread.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Samplestop_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    sampling = false;
                    samplestart.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonMinimumSetting_Click(object sender, EventArgs e)
        {

        }

        private void ButtonMaximumSetting_Click(object sender, EventArgs e)
        {

        }

        private void ButtonMachineStatusStart_Click(object sender, EventArgs e)
        {

        }

        private void ButtonMachineStatusClose_Click(object sender, EventArgs e)
        {

        }

        private void Savelog_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
