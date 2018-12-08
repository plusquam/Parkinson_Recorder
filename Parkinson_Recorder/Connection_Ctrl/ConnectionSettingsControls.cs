using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace Parkinson_Recorder
{
    public partial class ProgramMainWindow
    {
        private Connection_Ctrl.SerialCtrl _serialCtrl = new Parkinson_Recorder.Connection_Ctrl.SerialCtrl();
        private Data_Processing.ImuDataProcessing _imuData;
        private string _oryginalFile = @"C:\Users\plusq\Desktop\data.txt";
        private string _newFile = @"C:\Users\plusq\Desktop\pomiar3.txt";
        private string _compareFile = @"C:\Users\plusq\Desktop\compare.txt";

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            string portName = SerialPortsListBox.SelectedValue.ToString();
            string baud = BaudListBox.SelectedValue.ToString();

            if (!_serialCtrl.IsConnected)
                _serialCtrl.InitializePort(portName, int.Parse(baud), DataReceived);
            else if (portName != _serialCtrl.SerialName || baud != _serialCtrl.BaudRate.ToString())
            {
                _serialCtrl.Disconnect();
                _serialCtrl.InitializePort(portName, int.Parse(baud), DataReceived);
            }

            this.toolStripConnectionStatusIcon.BackgroundImage = global::Parkinson_Recorder.Properties.Resources.green_dot_17x17;
            DisconnectButton.Enabled = true;
        }

        private void ReScanButton_Click(object sender, EventArgs e)
        {
            SerialPortsListBox.DataSource = _serialCtrl.GetSerialPortsNames();
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            DisconnectButton.Enabled = false;
            _serialCtrl.Disconnect();
            _imuData.Clear();
            _ClearFreqChart();
            _ClearTimeChart();
            this.toolStripConnectionStatusIcon.BackgroundImage = global::Parkinson_Recorder.Properties.Resources.red_dot_17x17;

            serialWatchdogTimer.Enabled = false;
        }

        public void DataReceived(object sender)
        {
            serialWatchdogTimer.Enabled = true;
            serialWatchdogTimer.Stop();

            if (sender is SerialPort serialPort)
            {
                int count = serialPort.BytesToRead;
                if (count > 0)
                {
                    byte[] buffer = new byte[count];
                    if (serialPort.Read(buffer, 0, count) == count)
                        _imuData.PushData(buffer);
                    else
                        Console.WriteLine("Warning!!! Bytes count doesn't match!");
                }
                else Console.WriteLine("No data to read!");
            }

            serialWatchdogTimer.Start();
        }
    }
}