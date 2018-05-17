using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;
using Parkinson_Recorder.Data_Processing;

namespace Parkinson_Recorder
{
    public partial class ProgramMainWindow : Form
    {
        private double[] _newData = new double[2];
        private int _numberOfPointsInChart = 512;
        private int _numberOfFFTPoints = 64;

        private CsvParser _csvParser = new CsvParser(@"C:\Users\plusq\Desktop\TempFile.csv", 3);

        public ProgramMainWindow()
        {
            InitializeComponent();
            SerialPortsListBox.DataSource = _serialCtrl.GetSerialPortsNames();
            BaudListBox.DataSource = _serialCtrl.BaudRates;

            _imuData = new Data_Processing.ImuDataProcessing(_numberOfPointsInChart, _numberOfFFTPoints);
            _imuData.TimeChartRefreshEvent += new Data_Processing.ImuDataProcessing.ChartRefreshEventHandler(_RefreshTimeChart_Invoker);
            _imuData.FftChartRefreshEvent += new Data_Processing.ImuDataProcessing.ChartRefreshEventHandler(_RefreshFreqChart_Invoker);
            _imuData.SaveDataEvent += SaveDataToCsv;
            _InitializeTimeChart();
            _InitializeFreqChart();

            _csvParser.InitializeCsvFile();
        }

        private void _InitializeTimeChart()
        {
            signalTimeChart.Enabled = true;
            //signalTimeChart.ResetAutoValues();
            //signalTimeChart.Series[0].Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.;
        }

        private void _InitializeFreqChart()
        {
            signalFrequencyChart.Enabled = true;
            //signalFrequencyChart.ResetAutoValues();
            //signalTimeChart.Series[0].Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartStopMeasureButton_Click(object sender, EventArgs e)
        {
            /*if (this.signalTimeChart.Enabled)
            {
                this.signalTimeChart.Enabled = false;
                this.signalFrequencyChart.Enabled = false;
            }
            else
            {
                this.signalTimeChart.Enabled = true;
                this._dataChartsTimerInstance.ResetStartTime();
                this.signalTimeChart.Series[0].Points.Clear();
                this.signalFrequencyChart.Enabled = true;
            }*/
        }

        private void ShowFrequencyChartButton_Click(object sender, EventArgs e)
        {
            if(!chartsSplitContainer.Panel2Collapsed)
                chartsSplitContainer.Panel2Collapsed = true;

            else
                chartsSplitContainer.Panel2Collapsed = false;
        }

        private void ShowSignalsChartButton_Click(object sender, EventArgs e)
        {
            if(!chartsSplitContainer.Panel1Collapsed)
                chartsSplitContainer.Panel1Collapsed = true;
            else
                chartsSplitContainer.Panel1Collapsed = false;
        }

        private void _RefreshTimeChart_Invoker(object sender)
        {
            if (signalTimeChart.InvokeRequired)
                Invoke(new MethodInvoker(_RefreshTimeChart));
            else
                _RefreshTimeChart();
        }

        private void _RefreshTimeChart()
        {
            signalTimeChart.ResetAutoValues();
            signalTimeChart.Series["XAxis"].Points.DataBindXY(_imuData.TimeSeries, _imuData.XSeries);
            signalTimeChart.Series["YAxis"].Points.DataBindXY(_imuData.TimeSeries, _imuData.YSeries);
            signalTimeChart.Series["ZAxis"].Points.DataBindXY(_imuData.TimeSeries, _imuData.ZSeries);

            signalTimeChart.Invalidate();
        }

        private void _RefreshFreqChart_Invoker(object sender)
        {
            if (signalFrequencyChart.InvokeRequired)
                Invoke(new MethodInvoker(_RefreshFreqChart));
            else
                _RefreshFreqChart();
        }

        private void _RefreshFreqChart()
        {
            signalFrequencyChart.ResetAutoValues();

            signalFrequencyChart.Series["XAxis"].Points.DataBindXY(_imuData.FreqFTTArray, _imuData.XAxisFFTDataArray);
            signalFrequencyChart.Series["YAxis"].Points.DataBindXY(_imuData.FreqFTTArray, _imuData.YAxisFFTDataArray);
            signalFrequencyChart.Series["ZAxis"].Points.DataBindXY(_imuData.FreqFTTArray, _imuData.ZAxisFFTDataArray);

            signalFrequencyChart.Invalidate();
        }

        private void SaveDataToCsv(List<ImuData<float>> dataList)
        {
            _csvParser.WriteListOfData<float>(dataList);
        }

        private void newMeasureButton_Click(object sender, EventArgs e)
        {
            _serialCtrl.SendData("test");
        }

        private void openMeasureButton_Click(object sender, EventArgs e)
        {

        }

        private void saveMeasureButton_Click(object sender, EventArgs e)
        {
            String[] linesA = System.IO.File.ReadAllLines(_oryginalFile);
            String[] linesB = System.IO.File.ReadAllLines(_newFile);

            IEnumerable<String> onlyB = linesB.Except(linesA);

            System.IO.File.WriteAllLines(_compareFile, onlyB);

            MessageBox.Show("Comparing Done");
        }
    }


}
