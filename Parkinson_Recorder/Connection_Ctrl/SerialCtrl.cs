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

        public bool InitializePort(string portName, int baud)
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
            catch (System.UnauthorizedAccessException e)  // CS0168
            {
                System.Console.WriteLine(e.Message);
                MessageBox.Show(e.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Set System.UnauthorizedAccessException to the new exception's InnerException.
                //throw new System.UnauthorizedAccessException("Odmowa dostępu do portu " + portName, e);
                return false;
            }



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

        public void SendString(string msg)
        {
            if(isConnected)
                _serialPort.Write(msg);
        }



    }
}
