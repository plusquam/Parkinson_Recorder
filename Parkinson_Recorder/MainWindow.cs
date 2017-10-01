using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Parkinson_Recorder
{
    public partial class ProgramMainWindow : Form
    {
        private static int chartPointIndex = 0;
        private static double[] newData = new double[2];

        public ProgramMainWindow()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startStopMeasureButton_Click(object sender, EventArgs e)
        {
            if (this.signalTimeChart.Enabled)
            {
                this.signalTimeChart.Enabled = false;
                //this.signalFrequencyChart.Enabled = false;
                dataChartsTimer.Enabled = false;
                chartsRefreshingTimer.Enabled = false;
            }
            else
            {
                this.signalTimeChart.Enabled = true;
                this.signalTimeChart.Series[0].Points.Clear();
                //this.signalFrequencyChart.Enabled = true;
                dataChartsTimer.Enabled = true;
                chartsRefreshingTimer.Enabled = true;
            }
        }

        private void showFrequencyChartButton_Click(object sender, EventArgs e)
        {
            if(chartsSplitContainer.Panel2Collapsed == false)
            {
                chartsSplitContainer.Panel2Collapsed = true;
            }
            else
            {
                chartsSplitContainer.Panel2Collapsed = false;
            }
        }

        private void showSignalsChartButton_Click(object sender, EventArgs e)
        {
            if(chartsSplitContainer.Panel1Collapsed == false)
            {
                chartsSplitContainer.Panel1Collapsed = true;
            }
            else
            {
                chartsSplitContainer.Panel1Collapsed = false;
            }
        }

        private void chartsRefreshingTimer_Tick(object sender, EventArgs e)
        {
            int numberOfPointsInChart = 200;

            // Adjust Y & X axis scale
            signalTimeChart.ResetAutoValues();

            if (signalTimeChart.ChartAreas[0].AxisX.Maximum < newData[0])
            {
                signalTimeChart.ChartAreas[0].AxisX.Maximum = newData[0];
            }

            // Keep a constant number of points by removing them from the left
            while (signalTimeChart.Series[0].Points.Count > numberOfPointsInChart)
            {
                // Remove data points on the left side

                signalTimeChart.Series[0].Points.RemoveAt(0);
            }

            // Adjust X axis scale
            signalTimeChart.ChartAreas[0].AxisX.Minimum = signalTimeChart.Series[0].Points.First().XValue;
            signalTimeChart.ChartAreas[0].AxisX.Maximum = signalTimeChart.Series[0].Points.Last().XValue;

            // Redraw chart
            signalTimeChart.Invalidate();
        }

       
        private void dataChartsTimer_Tick(object sender, EventArgs e)
        {
            RealTimeData timeSignalInstance = new RealTimeData();
            newData = timeSignalInstance.generateData();

            // Define some variables
            signalTimeChart.Series[0].Points.AddXY(newData[0], newData[1]);
            ++chartPointIndex;
        }
    }


}
