using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using Parkinson_Recorder.Data_Processing;

namespace Parkinson_Recorder
{
    public partial class ProgramMainWindow
    {
        private Connection_Ctrl.SerialCtrl _serialCtrl = new Parkinson_Recorder.Connection_Ctrl.SerialCtrl();
        private Data_Processing.ImuDataProcessing _imuData;
        private CsvParser _csvParser;
        private Data_Processing.PatientData _patientData;

        private bool _isRecording = false;

        private Thread _serialReadingThread;
        private static Mutex _readThreadMutex = new Mutex();
        private bool _runReadingThread = false;

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            string portName = SerialPortsListBox.SelectedValue.ToString();
            string baud = BaudListBox.SelectedValue.ToString();

            if (!_serialCtrl.IsConnected)
                _serialCtrl.InitializePort(portName, int.Parse(baud), WokeReadThread);
            else if (portName != _serialCtrl.SerialName || baud != _serialCtrl.BaudRate.ToString())
            {
                _serialCtrl.Disconnect();
                _serialCtrl.InitializePort(portName, int.Parse(baud), WokeReadThread);
            }

            this.toolStripConnectionStatusIcon.BackgroundImage = global::Parkinson_Recorder.Properties.Resources.green_dot_17x17;
            DisconnectButton.Enabled = true;

            _serialReadingThread = new Thread(new ThreadStart(ReadSerialDataThreadFunction));
            _serialReadingThread.Priority = ThreadPriority.AboveNormal;
            _readThreadMutex.WaitOne();
            _runReadingThread = true;
            _readThreadMutex.ReleaseMutex();
            //_serialReadingThread.Start();
        }

        private void ReScanButton_Click(object sender, EventArgs e)
        {
            SerialPortsListBox.DataSource = _serialCtrl.GetSerialPortsNames();
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            if (_serialCtrl.IsConnected)
            {
                _readThreadMutex.WaitOne();
                _runReadingThread = false;
                _readThreadMutex.ReleaseMutex();

                if (_serialReadingThread.IsAlive)
                    _serialReadingThread.Join();

                DisconnectButton.Enabled = false;
                _serialCtrl.Disconnect();
                _imuData.Clear();
                _ClearFreqChart();
                _ClearTimeChart();
                this.toolStripConnectionStatusIcon.BackgroundImage = global::Parkinson_Recorder.Properties.Resources.red_dot_17x17;
            }
        }

        private void ReadSerialDataThreadFunction()
        {
            ulong emptyPackagesCounter = 0;

            while (true)
            {
                if (_serialCtrl.CheckConnection())
                { 
                    if (_readThreadMutex.WaitOne(5))
                        if (_runReadingThread)
                        {
                            _readThreadMutex.ReleaseMutex();
                            if (DataReceived(_serialCtrl.SerialPort))
                                emptyPackagesCounter = 0;
                            else
                                emptyPackagesCounter++;
                        }
                        else
                        {
                            _readThreadMutex.ReleaseMutex();
                            break;
                        }

                    if (emptyPackagesCounter > 30)
                        Thread.Sleep(300);
                    else
                        Thread.Sleep(10);
                }
                else
                {
                    break;
                }
            }
        }

        public void WokeReadThread(object sender)
        {
            if (!_serialReadingThread.IsAlive)
                _serialReadingThread.Start();
        }

        public bool DataReceived(object sender)
        {
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

                    return true;
                }
                else
                {
                    //Console.WriteLine("No data to read!");
                    return false;
                }
            }

            return false;
        }

        private bool ReadPatientData(ref PatientData data)
        {
            string name, surname;

            if (nameTextBox.Text.Length != 0)
                name = nameTextBox.Text;
            else
            {
                MessageBox.Show("Podaj imię pacjenta w zakładce danych pacjenta!", "Brak imienia pacjenta!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (surnameTextBox.Text.Length != 0)
                surname = surnameTextBox.Text;
            else
            {
                MessageBox.Show("Podaj nazwisko pacjenta w zakładce danych pacjenta!", "Brak nazwiska pacjenta!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var date = birthDateTimePicker.Value.Date;
            if (date == _programConfig.MaxDateTime)
            {
                MessageBox.Show("Podaj datę urodzenia pacjenta w zakładce danych pacjenta!", "Brak daty urodzenia pacjenta!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            var genderName = (string)genderListBox.SelectedItem;
            PatientData.Gender gender;
            if (genderName == "Mężczyzna")
                gender = PatientData.Gender.Man;
            else if (genderName == "Kobieta")
                gender = PatientData.Gender.Woman;
            else
            {
                MessageBox.Show("Wybierz płeć pacjenta w zakładce danych pacjenta!", "Brak płci pacjenta!",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            data = new PatientData(name, surname, date, gender);

            return true;
        }

        private bool StartMeasureSequence()
        {
            _imuData.Clear();
            _ClearTimeChart();
            _ClearFreqChart();

            if (!_csvParser.TempFileExist)
            {                
                if(!ReadPatientData(ref _patientData))
                    return false;
                if (!_csvParser.InitializeCsvFile(_patientData))
                    return false;
            }

            _csvParser.WriteNewMeasurement();

            if (!_serialCtrl.SendStartCommand())
                return false;

            return true;
        }

        private bool StopMeasureSequence()
        {
            if (!_csvParser.TempFileExist)
                return false;
            if (!_serialCtrl.SendStopCommand())
                return false;
            Thread.Sleep(20);
            _imuData.SaveData();

            return true;
        }
    }
}