using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkinson_Recorder.Data_Processing
{
    class CsvParser
    {
        private string _fileName;
        private StreamWriter _fileStream;
        private int _sensorCount;

        private bool _tempFileExist = false;
        private bool _fileSaved = false;

        string _targetFileName;
        

        public CsvParser(string fileName, int sensorsCount)
        {
            _fileName = fileName;
            _sensorCount = sensorsCount;
        }

        public bool InitializeCsvFile(Data_Processing.PatientData patientData)
        {
            try
            {
                _fileStream = File.CreateText(_fileName);
            }
            catch (UnauthorizedAccessException e)
            {
                System.Windows.Forms.MessageBox.Show("Plik tymczasowy " + _fileName + " jest obecnie zajęty przez inny proces. Zwolnij dostęp do pliku tymczasowego.", 
                                                     "Brak dostępu do pliku!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }

            _fileStream.AutoFlush = false;

            _targetFileName = patientData.Surname + '_' + patientData.Name + '_' + DateTime.Now.ToString("dd-MM-yy_HH-mm-ss") + ".csv";

            // Patient data saving
            _fileStream.Write("Dane pacjenta:" + _fileStream.NewLine);
            _fileStream.Write("Imie:,");
            _fileStream.Write(patientData.Name + _fileStream.NewLine);
            _fileStream.Write("Nazwisko:,");
            _fileStream.Write(patientData.Surname + _fileStream.NewLine);
            _fileStream.Write("Plec:,");
            if(patientData.GetGender == PatientData.Gender.Man)
                _fileStream.Write("M" + _fileStream.NewLine);
            else
                _fileStream.Write("K" + _fileStream.NewLine);

            _fileStream.Write("Data urodzenia:,");
            _fileStream.Write(patientData.BirthDate.ToString("dd.MM.yyyy") + _fileStream.NewLine);    
            _fileStream.Flush();

            _tempFileExist = true;

            return true;
        }

        public void WriteData<T>(ImuData<T> imuData)
        {
            string textToWrite = imuData.Time + ",";
            _fileStream.Write(textToWrite);

            if (imuData.SensorCount != _sensorCount)
                throw new Exception("Exception in CsvParser class: Sensor count doesn't match");

            if (imuData is ImuData<float>)
            {
                ImuData<float> imuDataCast = imuData as ImuData<float>;
                for (int i = 0; i < imuData.SensorCount; i++)
                {
                    textToWrite = imuDataCast.XAccel[i].ToString(System.Globalization.CultureInfo.InvariantCulture) + ",";
                    _fileStream.Write(textToWrite);
                    textToWrite = imuDataCast.YAccel[i].ToString(System.Globalization.CultureInfo.InvariantCulture) + ",";
                    _fileStream.Write(textToWrite);
                    textToWrite = imuDataCast.ZAccel[i].ToString(System.Globalization.CultureInfo.InvariantCulture) + ",";
                    _fileStream.Write(textToWrite);

                    textToWrite = imuDataCast.XGyro[i].ToString(System.Globalization.CultureInfo.InvariantCulture) + ",";
                    _fileStream.Write(textToWrite);
                    textToWrite = imuDataCast.YGyro[i].ToString(System.Globalization.CultureInfo.InvariantCulture) + ",";
                    _fileStream.Write(textToWrite);
                    textToWrite = imuDataCast.ZGyro[i].ToString(System.Globalization.CultureInfo.InvariantCulture);
                    if (i != _sensorCount - 1)
                        textToWrite += ",";
                    _fileStream.Write(textToWrite);
                }

                _fileStream.Write(_fileStream.NewLine);
                _fileStream.Flush();
            }
            else if (imuData is ImuData<double>)
            {
                ImuData<double> imuDataCast = imuData as ImuData<double>;
                for (int i = 0; i < imuData.SensorCount; i++)
                {
                    textToWrite = imuDataCast.XAccel[i].ToString(System.Globalization.CultureInfo.InvariantCulture) + ",";
                    _fileStream.Write(textToWrite);
                    textToWrite = imuDataCast.YAccel[i].ToString(System.Globalization.CultureInfo.InvariantCulture) + ",";
                    _fileStream.Write(textToWrite);
                    textToWrite = imuDataCast.ZAccel[i].ToString(System.Globalization.CultureInfo.InvariantCulture) + ",";
                    _fileStream.Write(textToWrite);

                    textToWrite = imuDataCast.XGyro[i].ToString(System.Globalization.CultureInfo.InvariantCulture) + ",";
                    _fileStream.Write(textToWrite);
                    textToWrite = imuDataCast.YGyro[i].ToString(System.Globalization.CultureInfo.InvariantCulture) + ",";
                    _fileStream.Write(textToWrite);
                    textToWrite = imuDataCast.ZGyro[i].ToString(System.Globalization.CultureInfo.InvariantCulture);
                    if (i != _sensorCount - 1)
                        textToWrite += ",";
                    _fileStream.Write(textToWrite);
                }

                _fileStream.Write(_fileStream.NewLine);
                _fileStream.Flush();
            }
            else
                throw new Exception("Exception in CsvParser class: Wrong IMU Data type");
        }

        public void WriteListOfData<T>(List<ImuData<T>> imuDataList)
        {
            foreach (ImuData<T> imuData in imuDataList)
            {
                WriteData<T>(imuData);
            }
        }

        public void WriteNewMeasurement()
        {
            _fileStream.Write(_fileStream.NewLine);
            _fileStream.Write(_fileStream.NewLine);
            _fileStream.Write("Pomiar rozpoczety:," + DateTime.Now.ToString("dd-MM-yy HH:mm:ss"));
            _fileStream.Write(_fileStream.NewLine);
            _fileStream.Write("Czas [ms],");

            for (int i = 0; i < _sensorCount; i++)
            {
                string textToWrite = "Akcelerometr_" + i.ToString() + "_X [mg],";
                _fileStream.Write(textToWrite);
                textToWrite = "Akcelerometr_" + i.ToString() + "_Y [mg],";
                _fileStream.Write(textToWrite);
                textToWrite = "Akcelerometr_" + i.ToString() + "_Z [mg],";
                _fileStream.Write(textToWrite);

                textToWrite = "Zyroskop_" + i.ToString() + "_X [mg],";
                _fileStream.Write(textToWrite);
                textToWrite = "Zyroskop_" + i.ToString() + "_Y [mg],";
                _fileStream.Write(textToWrite);
                textToWrite = "Zyroskop_" + i.ToString() + "_Z [mg]";
                if (i != _sensorCount - 1)
                    textToWrite += ",";
                _fileStream.Write(textToWrite);
            }

            _fileStream.Write(_fileStream.NewLine);
            _fileStream.Flush();
        }

        // TODO handlih all data saving cases
        public bool SaveFile()
        {
            System.Windows.Forms.SaveFileDialog dialog = new System.Windows.Forms.SaveFileDialog();
            dialog.Filter = "csv files (*.csv)|*.csv";
            dialog.DefaultExt = "csv";
            dialog.FileName = _targetFileName;
            dialog.AddExtension = true;
            dialog.OverwritePrompt = true;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.Copy(_fileName, dialog.FileName, true);
            }

            return true;
        }

        public string FileName { get => _fileName; set => _fileName = value; }
        public bool TempFileExist { get => _tempFileExist; set => _tempFileExist = value; }
        public bool FileSaved { get => _fileSaved; set => _fileSaved = value; }
    }
}
