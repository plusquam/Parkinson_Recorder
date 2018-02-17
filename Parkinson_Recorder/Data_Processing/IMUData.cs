using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkinson_Recorder.Data_Processing
{

    class IMUData
    {
        int dtm;
        double lastPrice = 0;
        public static System.Windows.Forms.DataVisualization.Charting.Chart Chart_ { get; set; }

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

        // a constructor to make life a little easier:
        public IMUData(int dt, double lpr)
        { Dtm = dt; LastPrice = lpr; }
    }
}
