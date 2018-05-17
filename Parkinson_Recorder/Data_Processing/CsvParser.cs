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
        private int _sensorCount = 1;

        public CsvParser(string fileName, int sensorsCount)
        {
            _fileName = fileName;
            _fileStream = File.CreateText(_fileName);

            _sensorCount = sensorsCount;
        }

        public void InitializeCsvFile()
        {
            _fileStream.AutoFlush = false;
            _fileStream.Write("Czas [ms],");

            for(int i = 0; i < _sensorCount; i++)
            {
                string textToWrite = "Akcelerometr_" + i.ToString() + "_X [mg],";
                _fileStream.Write(textToWrite);
                textToWrite = "Akcelerometr_" + i.ToString() + "_Y [mg],";
                _fileStream.Write(textToWrite);
                textToWrite = "Akcelerometr_" + i.ToString() + "_Z [mg],";
                _fileStream.Write(textToWrite);

                textToWrite = "Żyroskop_" + i.ToString() + "_X [mg],";
                _fileStream.Write(textToWrite);
                textToWrite = "Żyroskop_" + i.ToString() + "_Y [mg],";
                _fileStream.Write(textToWrite);
                textToWrite = "Żyroskop_" + i.ToString() + "_Z [mg]";
                if (i != _sensorCount - 1)
                    textToWrite += ",";
                _fileStream.Write(textToWrite);
            }

            _fileStream.Write(_fileStream.NewLine);
            _fileStream.Flush();
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
            
            _fileStream.Flush();
        }

        public string FileName { get => _fileName; set => _fileName = value; }
        public StreamWriter FileStream { get => _fileStream; set => _fileStream = value; }
    }
}
