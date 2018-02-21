using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parkinson_Recorder.Connection_Ctrl
{
    class SerialCtrl
    {
        public List<int> BaudRates = new List<int> { 9600, 19200, 38400, 57600, 115200, 230400, 460800};
        public delegate void DataReceivedHandler(object sender, System.IO.Ports.SerialDataReceivedEventArgs e);
        private DataReceivedHandler _receiveHandlerDelegate;

        private string[] _serialNames;
        private SerialPort _serialPort;
        public bool isConnected = false;
        private string _serialName;
        private int _baudRate;

        public string SerialName { get => _serialName; set => _serialName = value; }
        public int BaudRate { get => _baudRate; set => _baudRate = value; }

        public SerialCtrl()
        {
            // Get a list of serial port names.
            _serialNames = SerialPort.GetPortNames();
        }

        public string[] ScanPorts()
        {
            _serialNames = SerialPort.GetPortNames();
            return _serialNames;
        }

        public bool InitializePort(string portName, int baud, DataReceivedHandler dataReceiveHandler)
        {
            _serialPort = new SerialPort();
            _serialPort.PortName = portName;
            _serialName = portName;
            _serialPort.BaudRate = baud;
            _baudRate = baud;
            _serialPort.Parity = System.IO.Ports.Parity.None;
            _serialPort.DataBits = 8;
            _serialPort.StopBits = System.IO.Ports.StopBits.One;

            // Set the read/write timeouts
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;

            try
            {
                _serialPort.Open();
            }
            catch (System.UnauthorizedAccessException e)
            {
                System.Console.WriteLine(e.Message);
                MessageBox.Show(e.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Set System.UnauthorizedAccessException to the new exception's InnerException.
                //throw new System.UnauthorizedAccessException("Odmowa dostępu do portu " + portName, e);
                return false;
            }

            _receiveHandlerDelegate = dataReceiveHandler;
            _serialPort.ReceivedBytesThreshold = (6*3 + 1)*2;
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(_ByteReceived);

            isConnected = true;
            return true;
        }

        public void Disconnect()
        {
            if (isConnected)
            {
                _serialPort.Close();
                _serialPort = null;
                isConnected = false;
            }
        }

        public string[] GetSerialPortsNames()
        {
            Console.WriteLine("The following serial ports were found:");

            // Display each port name to the console.
            foreach (string port in _serialNames)
            {
                Console.WriteLine(port);
            }

            return _serialNames;
        }

        public bool SendData(byte data)
        {
            byte[] dataArray = new byte[] { data };
            if (isConnected)
            {
                _serialPort.Write(dataArray, 0, 1);
                return true;
            }
            return false;
        }

        public bool SendData(byte[] data, int count)
        {
            if (isConnected)
            {
                _serialPort.Write(data, 0, count);
                return true;
            }
            return false;
        }

        public bool SendData(string msg)
        {
            if (isConnected)
            {
                _serialPort.Write(msg);
                return true;
            }
            return false;
        }

        public byte ReadByte()
        {
            return (byte)_serialPort.ReadByte();
        }

        private void _ByteReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            _serialPort.DataReceived -= new SerialDataReceivedEventHandler(_ByteReceived);
            //await Task.Run(() => _receiveHandlerDelegate(sender, e));
            _receiveHandlerDelegate(sender, e);
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(_ByteReceived);
        }
    }
}
