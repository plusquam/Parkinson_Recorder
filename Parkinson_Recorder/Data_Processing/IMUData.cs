using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkinson_Recorder.Data_Processing
{
    class IMUData
    {
        private short _numberOfSensors;
        private enum _DataQueue {Time = -1, AccelX = 0, AccelY = 1, AccelZ = 2, GyroX = 3, GyroY = 4, GyroZ = 5};
        private const double accelMultiplicator = 0.061035156;
        private const double gyroMultiplicator = 0.061035156;

        int dtm;
        double lastPrice = 0;
        public static System.Windows.Forms.DataVisualization.Charting.Chart Chart_ { get; set; }

        // a constructor to make life a little easier:
        public IMUData(short sensorCount)
        {
            _numberOfSensors = sensorCount;
        }

        public int Dtm
        {
            get { return dtm; }
            set { dtm = value; }
        }

        public double LastPrice
        {
            get { return lastPrice; }
            set { lastPrice = value; Chart_.DataBind(); }
        }

        
    }
}
