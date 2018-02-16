using System;

namespace Parkinson_Recorder
{
    class RealTimeData
    {
        private Random random = new Random();
        private static TimeSpan startTime = DateTime.Now.TimeOfDay;


        public double[] generateData()
        {
            
            double[] data = new double[2];
            TimeSpan passedTime = DateTime.Now.TimeOfDay - startTime;

            data[0] = passedTime.TotalMilliseconds / 1000;

            data[1] = random.Next(-2000, 2000);

            return data;
        }

        public void resetStartTime()
        {
            startTime = DateTime.Now.TimeOfDay;
        }


}
}
