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
        private int _numberOfPointsInChart;
        private int _numberOfFFTPoints;

        private ProgramConfig _programConfig;

        public ProgramMainWindow()
        {
            _programConfig = new ProgramConfig();

            InitializeComponent();

            birthDateTimePicker.MaxDate = _programConfig.MaxDateTime;
            birthDateTimePicker.Value = birthDateTimePicker.MaxDate;

            _numberOfPointsInChart = _programConfig.Data.numberOfPointsInChart;
            _numberOfFFTPoints = _programConfig.Data.numberOfFftPoints;

            SerialPortsListBox.DataSource = _serialCtrl.GetSerialPortsNames();
            BaudListBox.DataSource = _serialCtrl.BaudRates;

            _imuData = new Data_Processing.ImuDataProcessing(_numberOfPointsInChart, _numberOfFFTPoints);
            _imuData.TimeChartRefreshEvent += _RefreshTimeChart_Invoker;
            _imuData.FftChartRefreshEvent += _RefreshFreqChart_Invoker;
            _imuData.SaveDataEvent += SaveDataToCsv;

            _InitializeTimeChart();
            _InitializeFreqChart();

            _csvParser = new CsvParser(_programConfig.Data.tempMeasurementFilePath, 3);
        }

        ~ProgramMainWindow()
        {
            DisconnectButton_Click(this, EventArgs.Empty);
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

        private void _ClearTimeChart()
        {
            foreach (var series in signalTimeChart.Series)
            {
                series.Points.Clear();
            }
            signalTimeChart.Invalidate();
        }

        private void _ClearFreqChart()
        {
            foreach (var series in signalFrequencyChart.Series)
            {
                series.Points.Clear();
            }
            signalFrequencyChart.Invalidate();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartStopMeasureButton_Click(object sender, EventArgs e)
        {
            if (!_isRecording)
            // Start measure sequence
            {
                if (!StartMeasureSequence())
                    return;

                this.newMeasureButton.Enabled = false;
                this.saveMeasureButton.Enabled = false;
                this.ConnectButton.Enabled = false;
                this.DisconnectButton.Enabled = false;

                this.nameTextBox.Enabled = false;
                this.surnameTextBox.Enabled = false;
                this.genderListBox.Enabled = false;
                this.birthDateTimePicker.Enabled = false;

                _csvParser.FileSaved = false;

                this.startStopMeasureButton.Image = Properties.Resources.stop_64;
            }
            else
            // Stop measure sequence
            {
                if (!StopMeasureSequence())
                    return;

                this.newMeasureButton.Enabled = true;
                if(_csvParser.TempFileExist)
                    this.saveMeasureButton.Enabled = true;
                this.ConnectButton.Enabled = true;
                this.DisconnectButton.Enabled = true;

                this.startStopMeasureButton.Image = Properties.Resources.record_64;
            }

            _isRecording = !_isRecording;
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

            if (_imuData.CurrentFftAxis == ImuDataProcessing.FftAxis.AxisX)
                signalFrequencyChart.Series["XAxis"].Points.DataBindXY(_imuData.FreqFTTArray, _imuData.XAxisFFTDataArray);
            else if (_imuData.CurrentFftAxis == ImuDataProcessing.FftAxis.AxisY)
                signalFrequencyChart.Series["YAxis"].Points.DataBindXY(_imuData.FreqFTTArray, _imuData.YAxisFFTDataArray);
            else if (_imuData.CurrentFftAxis == ImuDataProcessing.FftAxis.AxisZ)
                signalFrequencyChart.Series["ZAxis"].Points.DataBindXY(_imuData.FreqFTTArray, _imuData.ZAxisFFTDataArray);

            signalFrequencyChart.Invalidate();
        }

        private void SaveDataToCsv(List<ImuData<float>> dataList)
        {
            _csvParser.WriteListOfData<float>(dataList);
        }

        private void newMeasureButton_Click(object sender, EventArgs e)
        {
            this.nameTextBox.Enabled = true;
            this.surnameTextBox.Enabled = true;
            this.genderListBox.Enabled = true;
            this.birthDateTimePicker.Enabled = true;

            _csvParser.FileSaved = false;
        }

        private void openMeasureButton_Click(object sender, EventArgs e)
        {

        }

        private void saveMeasureButton_Click(object sender, EventArgs e)
        {
            _csvParser.SaveFile();
        }

        private void serialWatchdogTimer_Tick(object sender, EventArgs e)
        {
            _serialCtrl.RunByteReceivedEvent();
        }

        private void fftXRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _imuData.FftAxisToChange = ImuDataProcessing.FftAxis.AxisX;
            signalFrequencyChart.Series["YAxis"].Points.Clear();
            signalFrequencyChart.Series["ZAxis"].Points.Clear();
        }

        private void fftYRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _imuData.FftAxisToChange = ImuDataProcessing.FftAxis.AxisY;
            signalFrequencyChart.Series["XAxis"].Points.Clear();
            signalFrequencyChart.Series["ZAxis"].Points.Clear();
        }

        private void fftZRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            _imuData.FftAxisToChange = ImuDataProcessing.FftAxis.AxisZ;
            signalFrequencyChart.Series["XAxis"].Points.Clear();
            signalFrequencyChart.Series["YAxis"].Points.Clear();
        }

        private void ProgramMainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisconnectButton_Click(this, EventArgs.Empty);
        }

        private void PatientDataChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Patient data changed.");
        }
    }
}
