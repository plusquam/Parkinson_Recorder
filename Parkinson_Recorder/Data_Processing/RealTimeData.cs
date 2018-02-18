using System;
using System.Diagnostics;

namespace Parkinson_Recorder
{
    class RealTimeData
    {
        private Random _random;
        private Stopwatch _stopwatch = new Stopwatch();

        public RealTimeData()
        {
            this._random = new Random();
        }

        public double[] GenerateData()
        {
            double[] data = new double[2];

            data[0] = _stopwatch.ElapsedMilliseconds;
            data[1] = _random.Next(-2000, 2000);
 
            return data;
        }

        public void ResetStartTime()
        {
            _stopwatch.Reset();
            _stopwatch.Start();
        }


}
}
