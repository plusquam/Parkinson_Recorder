﻿using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;

namespace Parkinson_Recorder
{
    public partial class ProgramMainWindow : Form
    {
        private int _chartPointIndex = 0;
        private double[] _newData = new double[2];
        private RealTimeData _dataChartsTimerInstance = new RealTimeData();
        private double[,] _fftData = new double[2, 512];
        private int _numberOfPointsInChart = 1024;
        private Stopwatch _stopwatch = new Stopwatch();

        public ProgramMainWindow()
        {
            InitializeComponent();
            SerialPortsListBox.DataSource = _serialCtrl.GetSerialPortsNames();
            BaudListBox.DataSource = _serialCtrl.BaudRates;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartStopMeasureButton_Click(object sender, EventArgs e)
        {
            if (this.signalTimeChart.Enabled)
            {
                this.signalTimeChart.Enabled = false;
                this.signalFrequencyChart.Enabled = false;
                dataChartsTimer.Enabled = false;
                chartsRefreshingTimer.Enabled = false;
            }
            else
            {
                this.signalTimeChart.Enabled = true;
                this._dataChartsTimerInstance.ResetStartTime();
                this.signalTimeChart.Series[0].Points.Clear();
                this.signalFrequencyChart.Enabled = true;
                dataChartsTimer.Enabled = true;
                chartsRefreshingTimer.Enabled = true;
                dataChartsTimer.Start();
                chartsRefreshingTimer.Start();
            }
        }

        private void ShowFrequencyChartButton_Click(object sender, EventArgs e)
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

        private void ShowSignalsChartButton_Click(object sender, EventArgs e)
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

        private void ChartsRefreshingTimer_Tick(object sender, EventArgs e)
        {
            _stopwatch.Restart();

            // Adjust Y & X axis scale
            //signalTimeChart.ResetAutoValues();
            int counterTemp = 0;

            // Keep a constant number of points by removing them from the left
            while (signalTimeChart.Series[0].Points.Count > _numberOfPointsInChart)
            {
                // Remove data points on the left side
                counterTemp++;
                signalTimeChart.Series[0].Points.RemoveAt(0);
            }

            // Adjust X axis scale
            signalTimeChart.ChartAreas[0].AxisX.Minimum = signalTimeChart.Series[0].Points.First().XValue;
            signalTimeChart.ChartAreas[0].AxisX.Maximum = signalTimeChart.Series[0].Points.Last().XValue;

            // Redraw chart
            signalTimeChart.Invalidate();

            long microseconds = _stopwatch.ElapsedTicks / (Stopwatch.Frequency / 1000000L);
            //Console.WriteLine("Operation completed in: " + microseconds + " (us)");
            //Console.WriteLine("count: " + counterTemp);
        }
      
        private void DataChartsTimer_Tick(object sender, EventArgs e)
        {
            _newData = _dataChartsTimerInstance.GenerateData();

            // Define some variables
            signalTimeChart.Series[0].Points.AddXY(_newData[0], _newData[1]);
            ++_chartPointIndex;

            long microseconds = _stopwatch.ElapsedMilliseconds; // (Stopwatch.Frequency / 1000000L);
            Console.WriteLine("Operation completed in: " + microseconds + " (ms)");
        }

        private void newMeasureButton_Click(object sender, EventArgs e)
        {
            _serialCtrl.SendString("test");
        }


    }


}
