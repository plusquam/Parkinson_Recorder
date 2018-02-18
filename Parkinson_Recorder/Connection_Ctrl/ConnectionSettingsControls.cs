using System;
using System.Windows.Forms;

namespace Parkinson_Recorder
{
    public partial class ProgramMainWindow
    {
        private Connection_Ctrl.SerialCtrl _serialCtrl = new Parkinson_Recorder.Connection_Ctrl.SerialCtrl();
        private Data_Processing.IMUData _IMUData = new Data_Processing.IMUData(3);

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
            Console.WriteLine("Byte received: " + _serialCtrl.ReadByte());
        }

    }
}