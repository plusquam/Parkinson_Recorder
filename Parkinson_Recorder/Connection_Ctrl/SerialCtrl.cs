using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkinson_Recorder.Connection_Ctrl
{
    class SerialCtrl
    {
        private string[] _serialNames;
        private SerialPort _serialPort = new SerialPort();

        public SerialCtrl()
        {
            _serialPort.BaudRate = 9600;
        }

        public string[] GetSerialPortsNames()
        {
            // Get a list of serial port names.
            _serialNames = SerialPort.GetPortNames();

            Console.WriteLine("The following serial ports were found:");

            // Display each port name to the console.
            foreach (string port in _serialNames)
            {
                Console.WriteLine(port);
            }

            return _serialNames;
        }



    }
}
