using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parkinson_Recorder.Connection_Ctrl
{
    class SerialCtrl //: IDisposable
    {
        public List<int> BaudRates = new List<int> { 9600, 19200, 38400, 57600, 115200, 230400, 460800};
        public delegate void DataReceivedHandler(object sender);
        private DataReceivedHandler _receiveHandlerDelegate;

        private string[] _serialNames;
        private SerialPort _serialPort;
        private bool _isConnected = false;
        private string _serialName;
        private int _baudRate;

        public string SerialName { get => _serialName; set => _serialName = value; }
        public int BaudRate { get => _baudRate; set => _baudRate = value; }
        public bool IsConnected { get => _isConnected; set => _isConnected = value; }
        public SerialPort SerialPort { get => _serialPort; set => _serialPort = value; }

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
            _serialPort.ReadTimeout = System.IO.Ports.SerialPort.InfiniteTimeout;
            _serialPort.WriteTimeout = System.IO.Ports.SerialPort.InfiniteTimeout;

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
            //_serialPort.ReceivedBytesThreshold = 2;
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(_ByteReceived);

            _isConnected = true;
            Console.WriteLine("Serial port " + portName + " opened with baud: " + baud);
            return true;
        }

        public void Disconnect()
        {
            if (_isConnected)
            {
                _serialPort.Close();
                _serialPort = null;
                _isConnected = false;
                Console.WriteLine("Serial port " + _serialName + " disconnected.");
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
            if (_isConnected)
            {
                _serialPort.Write(dataArray, 0, 1);
                return true;
            }
            return false;
        }

        public bool SendData(byte[] data, int count)
        {
            if (_isConnected)
            {
                _serialPort.Write(data, 0, count);
                return true;
            }
            return false;
        }

        public bool SendData(string msg)
        {
            if (_isConnected)
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

        private void _ByteReceived(object sender, SerialDataReceivedEventArgs e)
        {
            _serialPort.DataReceived -= new SerialDataReceivedEventHandler(_ByteReceived);
            //await Task.Run(() => _receiveHandlerDelegate(sender, e));
            _receiveHandlerDelegate(sender);
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(_ByteReceived);
        }

        public void RunByteReceivedEvent()
        {
            _serialPort.DataReceived -= new SerialDataReceivedEventHandler(_ByteReceived);
            //await Task.Run(() => _receiveHandlerDelegate(sender, e));
            _receiveHandlerDelegate(_serialPort);
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(_ByteReceived);
        }
    }
}
