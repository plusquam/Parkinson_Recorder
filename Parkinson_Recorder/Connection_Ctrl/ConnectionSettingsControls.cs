using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace Parkinson_Recorder
{
    public partial class ProgramMainWindow
    {
        private Connection_Ctrl.SerialCtrl _serialCtrl = new Parkinson_Recorder.Connection_Ctrl.SerialCtrl();
        private Data_Processing.IMUData _IMUData = new Data_Processing.IMUData(3);
        private string _oryginalFile = @"C:\Users\plusq\Desktop\pomiar2.txt";
        private string _newFile = @"C:\Users\plusq\Desktop\pomiar3.txt";
        private string _compareFile = @"C:\Users\plusq\Desktop\compare.txt";

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            string portName = SerialPortsListBox.SelectedValue.ToString();
            Console.WriteLine("Selected port name: " + portName);

            string baud = BaudListBox.SelectedValue.ToString();
            Console.WriteLine("Selected baud: " + baud);

            if (!_serialCtrl.isConnected)
                _serialCtrl.InitializePort(portName, int.Parse(baud), DataReceived);
            else if (portName != _serialCtrl.SerialName || baud != _serialCtrl.BaudRate.ToString())
            {
                _serialCtrl.Disconnect();
                _serialCtrl.InitializePort(portName, int.Parse(baud), DataReceived);
            }

            DisconnectButton.Enabled = true;
        }

        private void ReScanButton_Click(object sender, EventArgs e)
        {
            SerialPortsListBox.DataSource = _serialCtrl.GetSerialPortsNames();
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            _serialCtrl.Disconnect();
            DisconnectButton.Enabled = false;
        }

        public void DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (sender is SerialPort serialPort)
            {
                int count = serialPort.BytesToRead;
                byte[] buffer = new byte[count];
                if(serialPort.Read(buffer, 0, count) == count)
                    System.IO.File.AppendAllText(_newFile, System.Text.Encoding.Default.GetString(buffer));
                else
                    Console.WriteLine("error");
            }
        }
    }
}