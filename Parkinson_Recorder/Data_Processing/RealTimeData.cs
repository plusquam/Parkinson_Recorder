using System;

namespace Parkinson_Recorder
{
    class RealTimeData
    {
        private Random random;
        private static TimeSpan startTime = DateTime.Now.TimeOfDay;

        public RealTimeData()
        {
            this.random = new Random();
        }

        public double[] GenerateData()
        {
            
            double[] data = new double[2];
            TimeSpan passedTime = DateTime.Now.TimeOfDay - startTime;

            data[0] = passedTime.TotalMilliseconds / 1000;

            data[1] = random.Next(-2000, 2000);

            return data;
        }

        public void ResetStartTime()
        {
            startTime = DateTime.Now.TimeOfDay;
        }


}
}
