using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkinson_Recorder.Data_Processing
{
    class ImuData<T>
    {
        private int _sensorCount;
        private string _time;
        private T[] _xAccel;
        private T[] _yAccel;
        private T[] _zAccel;
        private T[] _xGyro;
        private T[] _yGyro;
        private T[] _zGyro;

        public ImuData(int sensorsCount)
        {
            _sensorCount = sensorsCount;

            _xAccel = new T[_sensorCount];
            _yAccel = new T[_sensorCount];
            _zAccel = new T[_sensorCount];
            _xGyro = new T[_sensorCount];
            _yGyro = new T[_sensorCount];
            _zGyro = new T[_sensorCount];
        }

        public ImuData(string time, T[] xAccel, T[] yAccel, T[] zAccel, T[] xGyro, T[] yGyro, T[] zGyro)
        {
            _sensorCount = xAccel.Length;

            if(_sensorCount != yAccel.Length || _sensorCount != zAccel.Length || _sensorCount != xGyro.Length || _sensorCount != yGyro.Length || _sensorCount != zGyro.Length)
                throw new Exception("Exception: Arrays dimensions don't match!");

            _time = time;
            _xAccel = xAccel.Clone() as T[];
            _yAccel = yAccel.Clone() as T[];
            _zAccel = zAccel.Clone() as T[];
            _xGyro = xGyro.Clone() as T[];
            _yGyro = yGyro.Clone() as T[];
            _zGyro = zGyro.Clone() as T[];
        }

        public int SensorCount { get => _sensorCount; set => _sensorCount = value; }
        public string Time { get => _time; set => _time = value; }
        public T[] XAccel { get => _xAccel; set => _xAccel = value; }
        public T[] YAccel { get => _yAccel; set => _yAccel = value; }
        public T[] ZAccel { get => _zAccel; set => _zAccel = value; }
        public T[] XGyro { get => _xGyro; set => _xGyro = value; }
        public T[] YGyro { get => _yGyro; set => _yGyro = value; }
        public T[] ZGyro { get => _zGyro; set => _zGyro = value; } 
    }
}
