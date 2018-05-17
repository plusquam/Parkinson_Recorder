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
    class ImuDataProcessing
    {
        public enum SensorType { Accelerometer, Gyroscope };
        private enum _DataQueue { Time, AccelX, AccelY, AccelZ, GyroX, GyroY, GyroZ };

        private const int _numberOfSensors = 3;
        private int _numberOfChartPoints;
        private SensorType _currentSensorType = SensorType.Gyroscope;

        private int _byteCounter = 0;
        private int _currentSensor = 0;
        private int _plotingSensorNumber = 0;

        private int _fftDataCounter = 0;
        private int _numberOfFFTPoints;
        private double _samplingFreq = 0.0;
        private TimeSpan _previousTime = new TimeSpan();
        private TimeSpan _currentTime = new TimeSpan();

        private int _dataTresholdCouter = 0;
        private int _receivedMeasuresTreshold = 10;

        private _DataQueue _currentMeasure = _DataQueue.Time;
        
        private const float _accelMultiplicator = 0.06103516f;
        private const float _gyroMultiplicator = 0.007633588f;

        private uint _dataByteH = 0;

        private LinkedList<String>  _timeSeries =  new LinkedList<String>();

        private LinkedList<float> _xSeries = new LinkedList<float>();
        private LinkedList<float> _ySeries = new LinkedList<float>();
        private LinkedList<float> _zSeries = new LinkedList<float>();

        public LinkedList<String> TimeSeries { get => _timeSeries; set => _timeSeries = value; }
        public LinkedList<float> XSeries { get => _xSeries; set => _xSeries = value; }
        public LinkedList<float> YSeries { get => _ySeries; set => _ySeries = value; }
        public LinkedList<float> ZSeries { get => _zSeries; set => _zSeries = value; }

        private float[]    _xAxisDataArray;
        private float[]    _yAxisDataArray;
        private float[]    _zAxisDataArray;
        private float[]    _xAxisFFTDataArray;
        private float[]    _yAxisFFTDataArray;
        private float[]    _zAxisFFTDataArray;
        private int[]       _freqFTTArray;

        private List<ImuData<float>> _tempDataToSaveList = new List<ImuData<float>>();
        private ImuData<float> _tempDataToSave;

        public delegate void ChartRefreshEventHandler(object sender);
        public event ChartRefreshEventHandler TimeChartRefreshEvent;
        public event ChartRefreshEventHandler FftChartRefreshEvent;

        public delegate void SaveDataEventHandler<T>(List<ImuData<T>> dataList);
        public event SaveDataEventHandler<float> SaveDataEvent;

        private System.ComponentModel.BackgroundWorker _fftBackgroundWorker = new System.ComponentModel.BackgroundWorker();
        private System.ComponentModel.BackgroundWorker _dataSaveBackgroundWorker = new System.ComponentModel.BackgroundWorker();

        public int ReceivedMeasuresTreshold { get => _receivedMeasuresTreshold; set => _receivedMeasuresTreshold = value; }
        public float[] XAxisFFTDataArray { get => _xAxisFFTDataArray; set => _xAxisFFTDataArray = value; }
        public float[] YAxisFFTDataArray { get => _yAxisFFTDataArray; set => _yAxisFFTDataArray = value; }
        public float[] ZAxisFFTDataArray { get => _zAxisFFTDataArray; set => _zAxisFFTDataArray = value; }
        public int[] FreqFTTArray { get => _freqFTTArray; set => _freqFTTArray = value; }
        internal List<ImuData<float>> TempDataToSaveList { get => _tempDataToSaveList; set => _tempDataToSaveList = value; }

        public ImuDataProcessing(int numberOfChartPoints, int numberOfFFTPoints)
        {
            _numberOfChartPoints = numberOfChartPoints;
            _numberOfFFTPoints = numberOfFFTPoints;

            _xAxisDataArray = new float[_numberOfFFTPoints];
            _yAxisDataArray = new float[_numberOfFFTPoints];
            _zAxisDataArray = new float[_numberOfFFTPoints];
            _xAxisFFTDataArray = new float[_numberOfFFTPoints];
            _yAxisFFTDataArray = new float[_numberOfFFTPoints];
            _zAxisFFTDataArray = new float[_numberOfFFTPoints];

            _tempDataToSave = new ImuData<float>(_numberOfSensors);

            _fftBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(ComputeFFTandSendData);
            _dataSaveBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(CallDataSaveEvent);
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
                                _currentTime = TimeSpan.FromMilliseconds(tempData);
                                string timeString = _currentTime.ToString(@"hh\.mm\.ss\.fff");
                                _timeSeries.AddLast(timeString);
                                _tempDataToSave.Time = timeString;

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
                                    _xAxisDataArray[_fftDataCounter] = dataValue;
                                }
                                _tempDataToSave.XAccel[_currentSensor] = dataValue;

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
                                    _yAxisDataArray[_fftDataCounter] = dataValue;
                                }
                                _tempDataToSave.YAccel[_currentSensor] = dataValue;

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
                                    _zAxisDataArray[_fftDataCounter] = dataValue;
                                }
                                _tempDataToSave.ZAccel[_currentSensor] = dataValue;

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
                                    _xAxisDataArray[_fftDataCounter] = dataValue;
                                }
                                _tempDataToSave.XGyro[_currentSensor] = dataValue;

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
                                    _yAxisDataArray[_fftDataCounter] = dataValue;
                                }
                                _tempDataToSave.YGyro[_currentSensor] = dataValue;

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
                                    _zAxisDataArray[_fftDataCounter] = dataValue;
                                }
                                _tempDataToSave.ZGyro[_currentSensor] = dataValue;

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
                            _tempDataToSaveList.Add(_tempDataToSave);

                            _currentSensor = 0;
                            _currentMeasure = _DataQueue.Time;
                            _dataByteH = 0;

                            _dataTresholdCouter++;
                            if(_dataTresholdCouter >= _receivedMeasuresTreshold)
                            {
                                while (_dataSaveBackgroundWorker.IsBusy)
                                { }
                                _dataSaveBackgroundWorker.RunWorkerAsync();

                                _dataTresholdCouter = 0;
                                TimeChartRefreshEvent(this);
                            }

                            _fftDataCounter++;
                            if(_fftDataCounter >= _numberOfFFTPoints)
                            {
                                _fftDataCounter = 0;
                                _samplingFreq = 1000.0 / (double)(_currentTime - _previousTime).Milliseconds;

                                while(_fftBackgroundWorker.IsBusy)
                                { }
                                _xAxisFFTDataArray = _xAxisDataArray.Clone() as float[];
                                _yAxisFFTDataArray = _yAxisDataArray.Clone() as float[];
                                _zAxisFFTDataArray = _zAxisDataArray.Clone() as float[];
                                _fftBackgroundWorker.RunWorkerAsync();
                            }

                            _previousTime = _currentTime;
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

        private void ComputeFFTandSendData(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            float[] imagValues = new float[_numberOfFFTPoints];
            Array.Clear(imagValues, 0, _numberOfFFTPoints);
            int m = (int)Math.Log(_numberOfFFTPoints, 2);

            _xAxisFFTDataArray = ComputeRealFFTValues(m, _xAxisFFTDataArray, imagValues, _samplingFreq, ref _freqFTTArray);
            Array.Clear(imagValues, 0, _numberOfFFTPoints);

            _yAxisFFTDataArray = ComputeRealFFTValues(m, _yAxisFFTDataArray, imagValues);
            Array.Clear(imagValues, 0, _numberOfFFTPoints);

            _zAxisFFTDataArray = ComputeRealFFTValues(m, _zAxisFFTDataArray, imagValues);

            FftChartRefreshEvent(this);
        }

        static public double[] ComputeRealFFTValues(int m, double[] realValues, double[] imagValues, double sampleFrequency, ref int[] freqValues)
        {
            double[] fftAbsValuesArray = new double[realValues.Length / 2];
            FFTLibrary.Complex.FFT(1, m, realValues, imagValues);

            double smallestFreq = sampleFrequency / (double)realValues.Length;

            freqValues = new int[fftAbsValuesArray.Length];
            for (int i = 0; i < realValues.Length / 2; i++)
            {
                fftAbsValuesArray[i] = 2.0 * Math.Sqrt( realValues[i]*realValues[i] + imagValues[i]*imagValues[i] );
                freqValues[i] = (int)(smallestFreq * i);
            }

            return fftAbsValuesArray;
        }

        static public float[] ComputeRealFFTValues(int m, float[] realValues, float[] imagValues, double sampleFrequency, ref int[] freqValues)
        {
            float[] fftAbsValuesArray = new float[realValues.Length / 2];
            FFTLibrary.Complex.FFT(1, m, realValues, imagValues);

            double smallestFreq = sampleFrequency / (double)realValues.Length;

            freqValues = new int[fftAbsValuesArray.Length];
            for (int i = 0; i < realValues.Length / 2; i++)
            {
                fftAbsValuesArray[i] = 2.0f * (float)Math.Sqrt(realValues[i] * realValues[i] + imagValues[i] * imagValues[i]);
                freqValues[i] = (int)(smallestFreq * i);
            }

            return fftAbsValuesArray;
        }

        static public double[] ComputeRealFFTValues(int m, double[] realValues, double[] imagValues)
        {
            double[] fftAbsValuesArray = new double[realValues.Length / 2];
            FFTLibrary.Complex.FFT(1, m, realValues, imagValues);

            for (int i = 0; i < realValues.Length / 2; i++)
            {
                fftAbsValuesArray[i] = Math.Sqrt(realValues[i] * realValues[i] + imagValues[i] * imagValues[i]);
            }
            return fftAbsValuesArray;
        }

        static public float[] ComputeRealFFTValues(int m, float[] realValues, float[] imagValues)
        {
            float[] fftAbsValuesArray = new float[realValues.Length / 2];
            FFTLibrary.Complex.FFT(1, m, realValues, imagValues);

            for (int i = 0; i < realValues.Length / 2; i++)
            {
                fftAbsValuesArray[i] = (float)Math.Sqrt(realValues[i] * realValues[i] + imagValues[i] * imagValues[i]);
            }
            return fftAbsValuesArray;
        }

        private void CallDataSaveEvent(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            List<ImuData<float>> _tempList = _tempDataToSaveList;
            _tempDataToSaveList = new List<ImuData<float>>();

            SaveDataEvent(_tempList);
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
