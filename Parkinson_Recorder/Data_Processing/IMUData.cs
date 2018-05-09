#define TEST_FILE
//#define SHOW_DATA_ON_CONSOLE

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FFTLibrary;

namespace Parkinson_Recorder.Data_Processing
{
    class IMUData
    {
        public enum SensorType { Accelerometer, Gyroscope };
        private enum _DataQueue { Time, AccelX, AccelY, AccelZ, GyroX, GyroY, GyroZ };

        private const int _numberOfSensors = 3;
        private int _numberOfChartPoints;
        private SensorType _currentSensorType = SensorType.Accelerometer;

        private int _byteCounter = 0;
        private int _currentSensor = 0;
        private int _plotingSensorNumber = 0;

        private int _fftDataCounter = 0;
        private int _numberOfFFTPoints;

        private int _dataTresholdCouter = 0;
        private int _receivedMeasuresTreshold = 20;

        private _DataQueue _currentMeasure = _DataQueue.Time;
        
        private const float _accelMultiplicator = 0.06103516f;
        private const float _gyroMultiplicator = 0.007633588f;

        private uint _dataByteH = 0;

        private System.IO.StreamWriter _fileStream = System.IO.File.CreateText(@"C:\Users\plusq\Desktop\pomiar3.txt");

        private LinkedList<short>  _timeSeries =  new LinkedList<short>();

        private LinkedList<float> _xSeries = new LinkedList<float>();
        private LinkedList<float> _ySeries = new LinkedList<float>();
        private LinkedList<float> _zSeries = new LinkedList<float>();

        public LinkedList<short> TimeSeries { get => _timeSeries; set => _timeSeries = value; }
        public LinkedList<float> XSeries { get => _xSeries; set => _xSeries = value; }
        public LinkedList<float> YSeries { get => _ySeries; set => _ySeries = value; }
        public LinkedList<float> ZSeries { get => _zSeries; set => _zSeries = value; }

        private double[] _xAxisDataArray;
        private double[] _yAxisDataArray;
        private double[] _zAxisDataArray;
        private double[] _xAxisFFTDataArray;
        private double[] _yAxisFFTDataArray;
        private double[] _zAxisFFTDataArray;

        public delegate void ChartRefreshEventHandler(object sender);
        public event ChartRefreshEventHandler ChartRefreshEvent;

        public delegate void DataNumberReachEventHandler(object sender);
        public event DataNumberReachEventHandler DataNumberReachEvent;
        private System.ComponentModel.BackgroundWorker fftBackgroundWorker = new System.ComponentModel.BackgroundWorker();

        public int ReceivedMeasuresTreshold { get => _receivedMeasuresTreshold; set => _receivedMeasuresTreshold = value; }
        public double[] XAxisFFTDataArray { get => _xAxisFFTDataArray; set => _xAxisFFTDataArray = value; }
        public double[] YAxisFFTDataArray { get => _yAxisFFTDataArray; set => _yAxisFFTDataArray = value; }
        public double[] ZAxisFFTDataArray { get => _zAxisFFTDataArray; set => _zAxisFFTDataArray = value; }

        public IMUData(int numberOfChartPoints, int numberOfFFTPoints)
        {
            _numberOfChartPoints = numberOfChartPoints;
            _numberOfFFTPoints = numberOfFFTPoints;

            _xAxisDataArray = new double[_numberOfFFTPoints];
            _yAxisDataArray = new double[_numberOfFFTPoints];
            _zAxisDataArray = new double[_numberOfFFTPoints];
            _xAxisFFTDataArray = new double[_numberOfFFTPoints];
            _yAxisFFTDataArray = new double[_numberOfFFTPoints];
            _zAxisFFTDataArray = new double[_numberOfFFTPoints];

            fftBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(computeFFTandSendData);
        }

        public void PushData(byte[] data)
        {
            foreach ( byte currentByte in data)
            {
#if TEST_FILE
                if (_byteCounter % 4 == 3)
                {
                    short tempData = (short)((_dataByteH << 4) + _GetHexFromAsciiChar(currentByte));
                    #if SHOW_DATA_ON_CONSOLE
                        Console.Write(_GetHexFromAsciiChar(currentByte) + " -> ");
                        Console.Write(tempData);
                    #endif
#else
                    if (_byteCounter % 2 == 1)
                {
                    short tempData = (short)((_dataByteH << 8 ) + currentByte );
#endif
                    while (_timeSeries.Count > _numberOfChartPoints && _zSeries.Count > _numberOfChartPoints && _timeSeries.Count != 0)
                    {
                        _timeSeries.RemoveFirst();
                        _xSeries.RemoveFirst();
                        _ySeries.RemoveFirst();
                        _zSeries.RemoveFirst();
                    }

                    float dataValue;

                    switch (_currentMeasure)
                    {
                        case _DataQueue.Time:
                            {
                                _timeSeries.AddLast(tempData);
                                _fileStream.Write(tempData.ToString() + ";");
                                #if SHOW_DATA_ON_CONSOLE
                                    Console.Write( "  " + tempData.ToString() + Environment.NewLine);
                                    Console.WriteLine("New measure.");
                                #endif
                                break;
                            }
                        case _DataQueue.AccelX:
                            {
                                dataValue = (float)tempData * _accelMultiplicator;
                                if (_plotingSensorNumber == _currentSensor && _currentSensorType == SensorType.Accelerometer)
                                {
                                    _xSeries.AddLast(dataValue);
                                    _xAxisDataArray[_fftDataCounter] = (double)dataValue;
                                }
                                _fileStream.Write(dataValue.ToString() + ';');
                                #if SHOW_DATA_ON_CONSOLE
                                    Console.Write("  " + dataValue.ToString() + Environment.NewLine);
                                #endif
                                break;
                            }
                        case _DataQueue.AccelY:
                            {
                                dataValue = (float)tempData * _accelMultiplicator;
                                if (_plotingSensorNumber == _currentSensor && _currentSensorType == SensorType.Accelerometer)
                                {
                                    _ySeries.AddLast(dataValue);
                                    _yAxisDataArray[_fftDataCounter] = (double)dataValue;
                                }
                                _fileStream.Write(dataValue.ToString() + ";");
                                #if SHOW_DATA_ON_CONSOLE
                                    Console.Write("  " + dataValue.ToString() + Environment.NewLine);
                                #endif
                                break;
                            }
                        case _DataQueue.AccelZ:
                            {
                                dataValue = (float)tempData * _accelMultiplicator;
                                if (_plotingSensorNumber == _currentSensor && _currentSensorType == SensorType.Accelerometer)
                                {
                                    _zSeries.AddLast(dataValue);
                                    _zAxisDataArray[_fftDataCounter] = (double)dataValue;
                                }
                                _fileStream.Write(dataValue.ToString() + ";");
                                #if SHOW_DATA_ON_CONSOLE
                                    Console.Write("  " + dataValue.ToString() + Environment.NewLine);
                                #endif
                                break;
                            }
                        case _DataQueue.GyroX:
                            {
                                dataValue = (float)tempData * _gyroMultiplicator;
                                if (_plotingSensorNumber == _currentSensor && _currentSensorType == SensorType.Gyroscope)
                                {
                                    _xSeries.AddLast(dataValue);
                                    _xAxisDataArray[_fftDataCounter] = (double)dataValue;
                                }
                                _fileStream.Write(dataValue.ToString() + ";");
                                #if SHOW_DATA_ON_CONSOLE
                                    Console.Write("  " + dataValue.ToString() + Environment.NewLine);
                                #endif
                                break;
                            }
                        case _DataQueue.GyroY:
                            {
                                dataValue = (float)tempData * _gyroMultiplicator;
                                if (_plotingSensorNumber == _currentSensor && _currentSensorType == SensorType.Gyroscope)
                                {
                                    _ySeries.AddLast(dataValue);
                                    _yAxisDataArray[_fftDataCounter] = (double)dataValue;
                                }
                                    _fileStream.Write(dataValue.ToString() + ";");
                                #if SHOW_DATA_ON_CONSOLE
                                    Console.Write("  " + dataValue.ToString() + Environment.NewLine);
                                #endif
                                break;
                            }   
                        case _DataQueue.GyroZ:
                            {
                                dataValue = (float)tempData * _gyroMultiplicator;
                                if (_plotingSensorNumber == _currentSensor && _currentSensorType == SensorType.Gyroscope)
                                {
                                    _zSeries.AddLast(dataValue);
                                    _zAxisDataArray[_fftDataCounter] = (double)dataValue;
                                }
                                    _fileStream.Write(dataValue.ToString() + ";");
                                #if SHOW_DATA_ON_CONSOLE
                                    Console.Write("  " + dataValue.ToString() + Environment.NewLine);
                                #endif
                                break;
                            }
                        default:
                            Console.WriteLine("Enumeration fail");
                            break;
                    }
                    
                    _currentMeasure++;

                    if (_currentMeasure > _DataQueue.GyroZ)
                    {
                        _currentSensor++;
                        #if SHOW_DATA_ON_CONSOLE
                            Console.WriteLine("Next sensor");
                        #endif
                        if (_currentSensor >= _numberOfSensors)
                        {
                            _currentSensor = 0;
                            _currentMeasure = _DataQueue.Time;
                            _dataByteH = 0;

                            _dataTresholdCouter++;
                            if(_dataTresholdCouter >= _receivedMeasuresTreshold)
                            {
                                _dataTresholdCouter = 0;
                                ChartRefreshEvent(this);
                            }

                            _fftDataCounter++;
                            if(_fftDataCounter >= _numberOfFFTPoints)
                            {
                                _fftDataCounter = 0;

                                while(fftBackgroundWorker.IsBusy)
                                { }
                                _xAxisFFTDataArray = _xAxisDataArray.Clone() as double[];
                                _yAxisFFTDataArray = _yAxisDataArray.Clone() as double[];
                                _zAxisFFTDataArray = _zAxisDataArray.Clone() as double[];
                                fftBackgroundWorker.RunWorkerAsync();
                            }

                            _fileStream.Write(Environment.NewLine);
                        }
                        else
                            _currentMeasure = _DataQueue.AccelX;
                    }
                }
                else
                {
#if TEST_FILE
                    _dataByteH = (_dataByteH << 4) + (uint)_GetHexFromAsciiChar(currentByte);
                    #if SHOW_DATA_ON_CONSOLE
                        Console.Write(_GetHexFromAsciiChar(currentByte).ToString() + "|");
                    #endif
#else
                    _dataByteH = currentByte;
#endif
                }

                _byteCounter++;
            }
        }

        private void computeFFTandSendData(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            double[] imagValues = new double[_numberOfFFTPoints];
            Array.Clear(imagValues, 0, _numberOfFFTPoints);
            int m = (int)Math.Log(_numberOfFFTPoints, 2);

            FFTLibrary.Complex.FFT(1, m, _xAxisFFTDataArray, imagValues);
            Array.Clear(imagValues, 0, _numberOfFFTPoints);
            FFTLibrary.Complex.FFT(1, m, _yAxisFFTDataArray, imagValues);
            Array.Clear(imagValues, 0, _numberOfFFTPoints);
            FFTLibrary.Complex.FFT(1, m, _zAxisFFTDataArray, imagValues);

            DataNumberReachEvent(this);
        }

#if TEST_FILE
        private byte _GetHexFromAsciiChar(byte inChar)
        {
            byte hexValue = 0;

            if (inChar >= 97) // 'a'
                hexValue = Convert.ToByte((int)inChar - 97 + 10);
            else if (inChar >= 65) //'A'
                hexValue = Convert.ToByte((int)inChar - 65 + 10);
            else
                hexValue = Convert.ToByte((int)inChar - 48);

            return hexValue;
        }
#endif
    }
}
