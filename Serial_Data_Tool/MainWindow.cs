﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace Serial_Data_Tool
{
    public partial class MainWindow : Form
    {
        private Parkinson_Recorder.Connection_Ctrl.SerialCtrl _serialCtrl = new Parkinson_Recorder.Connection_Ctrl.SerialCtrl();
        private string _messageBoxText = string.Empty;
        private string _sendFilePath = "C:\\Users\\plusq\\Desktop\\pomiar.txt";
        private string _sendFileContent = string.Empty;
        private int _numberOfSensors = 3;
        private int _dataSendIdx = 0, _dataSendIdxInterval; // (time + (Ax + Ay + Az + Gx + Gy + Gz) * sens_count) * 4 hex chars
        private System.Diagnostics.Stopwatch _dataSendStopwatch = new System.Diagnostics.Stopwatch();

        public MainWindow()
        {
            InitializeComponent();

            // Sensor data
            _dataSendIdxInterval = (1 + 6 * _numberOfSensors) * 4;
            
            // Serial connection
            SerialPortsListBox.DataSource = _serialCtrl.GetSerialPortsNames();
            BaudListBox.DataSource = _serialCtrl.BaudRates;

            // File path text box
            fileAdressTextBox.Text = _sendFilePath;
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            string portName = SerialPortsListBox.SelectedValue.ToString();
            string baud = BaudListBox.SelectedValue.ToString();

            if (!_serialCtrl.IsConnected)
                _serialCtrl.InitializePort(portName, int.Parse(baud), DataReceived);
            else if (portName != _serialCtrl.SerialName || baud != _serialCtrl.BaudRate.ToString())
            {
                _serialCtrl.Disconnect();
                _serialCtrl.InitializePort(portName, int.Parse(baud), DataReceived);
            }

            DisconnectButton.Enabled = true;
        }

        private void ReScanButton_Click(object sender, EventArgs e)
        {
            SerialPortsListBox.DataSource = _serialCtrl.GetSerialPortsNames();
        }

        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            _serialCtrl.Disconnect();

            DisconnectButton.Enabled = false;
        }

        public void DataReceived(object sender)
        {
            if (sender is SerialPort serialPort)
            {
                int count = serialPort.BytesToRead;
                if (count > 0)
                {
                    byte[] buffer = new byte[count];
                    if (serialPort.Read(buffer, 0, count) == count)
                    {
                        _messageBoxText = System.Text.Encoding.ASCII.GetString(buffer);

                        if (MessageDisplayBox.InvokeRequired)
                            Invoke(new MethodInvoker(AppendMessageBoxText));
                        else
                            AppendMessageBoxText();
                    }
                    else
                        Console.WriteLine("Warning!!! Bytes count doesn't match!");
                }
                else Console.WriteLine("No data to read!");
            }
        }

        private void clearMsgWindowButton_Click(object sender, EventArgs e)
        {
            MessageDisplayBox.Clear();
        }

        private void AppendMessageBoxText()
        {
            MessageDisplayBox.AppendText(_messageBoxText);
        }

        private void openFileDialogButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\Users\\plusq\\Desktop\\pomiar.txt";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 0;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    _sendFilePath = openFileDialog.FileName;
                    fileAdressTextBox.Text = _sendFilePath;
                }
            }    
        }

        private void sendFileButton_Click(object sender, EventArgs e)
        {
            stopTransmissionButton.Enabled = true;

            //Read the contents of the file into a stream
            using (StreamReader reader = new StreamReader(_sendFilePath))
            {
                _sendFileContent = reader.ReadToEnd();
            }

            dataSendTimer.Start();
            sendProgressBar.Visible = true;
        }

        private void fileAdressTextBox_TextChanged(object sender, EventArgs e)
        {
            if(_sendFilePath != fileAdressTextBox.Text)
                _sendFilePath = fileAdressTextBox.Text;
        }

        private void stopTransmissionButton_Click(object sender, EventArgs e)
        {
            _dataSendIdx = _sendFileContent.Length;
        }

        private bool SendMeasurement()
        {
            if (_dataSendIdx + _dataSendIdxInterval < _sendFileContent.Length)
            {
                string message = _sendFileContent.Substring(_dataSendIdx, _dataSendIdxInterval);
                byte[] buffer = System.Text.Encoding.ASCII.GetBytes(message);
                _serialCtrl.SendData(buffer, buffer.Length);
            }
            
            _dataSendIdx += _dataSendIdxInterval;
            var progress = _dataSendIdx * 100 / _sendFileContent.Length;
            sendProgressBar.Value = progress;

            if (_dataSendIdx >= _sendFileContent.Length)
            {
                dataSendTimer.Stop();
                sendProgressBar.Visible = false;
                sendProgressBar.Value = 0;
                _dataSendIdx = 0;

                return false;
            }

            //Console.WriteLine(_dataSendStopwatch.ElapsedMilliseconds);
            _dataSendStopwatch.Stop();
            measurementTimeValueBox.Text = _dataSendStopwatch.ElapsedMilliseconds.ToString();
            _dataSendStopwatch.Restart();

            return true;
        }

        private void dataSendTimer_Tick(object sender, EventArgs e)
        {
            if (!SendMeasurement())
            {
                stopTransmissionButton.Enabled = false;
                measurementTimeValueBox.Text = "";
            }
        }   
    }
}
