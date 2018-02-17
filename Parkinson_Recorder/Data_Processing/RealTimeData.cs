using System;
using System.Diagnostics;

namespace Parkinson_Recorder
{
    class RealTimeData
    {
        private Random random;
        private Stopwatch stopwatch = new Stopwatch();

        public RealTimeData()
        {
            this.random = new Random();
        }

        public double[] GenerateData()
        {
            double[] data = new double[2];

            data[0] = stopwatch.ElapsedMilliseconds;
            data[1] = random.Next(-2000, 2000);

            return data;
        }

        public void ResetStartTime()
        {
            stopwatch.Reset();
            stopwatch.Start();
        }


}
}
