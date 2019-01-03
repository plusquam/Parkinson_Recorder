//#define TEST_FILE
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
        public enum FftAxis { AxisX, AxisY, AxisZ };
        private enum _DataQueue { Time, AccelX, AccelY, AccelZ, GyroX, GyroY, GyroZ };

        private const int _numberOfSensors = 3;
        private int _numberOfChartPoints;
        private SensorType _currentSensorType = SensorType.Accelerometer;
        private FftAxis _currentFftAxis = FftAxis.AxisX;
        private FftAxis _fftAxisToChange = FftAxis.AxisX;

        private int _byteCounter = 0;
        private int _currentSensor = 0;
        private int _plotingSensorNumber = 0;

        private int _fftDataCounter = 0;
        private int _numberOfFFTPoints;
        private double _samplingFreq = 0.0;
        private TimeSpan _previousTime = new TimeSpan();
        private TimeSpan _currentTime = new TimeSpan();

        private int _dataTresholdCounter = 0;
        private int _receivedMeasuresTreshold = 100;

        private _DataQueue _currentMeasure = _DataQueue.Time;
        
        private const float _accelMultiplicator = 0.06103516f;
        private const float _gyroMultiplicator = 0.007633588f;

        private uint _dataByteH = 0;

        private LinkedList<String>  _timeSeries;

        private LinkedList<float> _xSeries;
        private LinkedList<float> _ySeries;
        private LinkedList<float> _zSeries;

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

        private float[] _imagFFTValues;
        private int _fftRank;

        private List<ImuData<float>> _tempDataToSaveList;
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
        public List<ImuData<float>> TempDataToSaveList { get => _tempDataToSaveList; set => _tempDataToSaveList = value; }
        public FftAxis CurrentFftAxis { get => _currentFftAxis; set => _currentFftAxis = value; }
        public FftAxis FftAxisToChange { get => _fftAxisToChange; set => _fftAxisToChange = value; }

        public ImuDataProcessing(int numberOfChartPoints, int numberOfFFTPoints)
        {
            _numberOfChartPoints = numberOfChartPoints;
            _numberOfFFTPoints = numberOfFFTPoints;

            _InitializeComponents();

            _fftBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(_ComputeFFTandSendData);
            _dataSaveBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(DataSaveEventCall);
        }

        private void _InitializeComponents()
        {
            _timeSeries = new LinkedList<String>();

            _xSeries = new LinkedList<float>();
            _ySeries = new LinkedList<float>();
            _zSeries = new LinkedList<float>();

            _xAxisDataArray = new float[_numberOfFFTPoints];
            _yAxisDataArray = new float[_numberOfFFTPoints];
            _zAxisDataArray = new float[_numberOfFFTPoints];
            _xAxisFFTDataArray = new float[_numberOfFFTPoints];
            _yAxisFFTDataArray = new float[_numberOfFFTPoints];
            _zAxisFFTDataArray = new float[_numberOfFFTPoints];

            _imagFFTValues = new float[_numberOfFFTPoints];
            Array.Clear(_imagFFTValues, 0, _numberOfFFTPoints);
            _fftRank = (int)Math.Log(_numberOfFFTPoints, 2);

            _tempDataToSave = new ImuData<float>(_numberOfSensors);
            _tempDataToSaveList = new List<ImuData<float>>();

            _currentSensorType = SensorType.Accelerometer;
            _currentFftAxis = FftAxis.AxisY;

            _byteCounter = 0;
            _currentSensor = 0;
            _plotingSensorNumber = 0;

            _fftDataCounter = 0;
            _samplingFreq = 0.0;
            _previousTime = new TimeSpan();
            _currentTime = new TimeSpan();

            _dataTresholdCounter = 0;
            _receivedMeasuresTreshold = 10;

            _currentMeasure = _DataQueue.Time;

            _dataByteH = 0;
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
                                    if(_currentFftAxis == FftAxis.AxisX)
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
                                    if (_currentFftAxis == FftAxis.AxisY)
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
                                    if (_currentFftAxis == FftAxis.AxisZ)
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
                                    if (_currentFftAxis == FftAxis.AxisX)
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
                                    if (_currentFftAxis == FftAxis.AxisY)
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
                                    if (_currentFftAxis == FftAxis.AxisZ)
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
                            _tempDataToSave = new ImuData<float>(_numberOfSensors);

                            _currentSensor = 0;
                            _currentMeasure = _DataQueue.Time;
                            _dataByteH = 0;

                            _dataTresholdCounter++;
                            if(_dataTresholdCounter >= _receivedMeasuresTreshold)
                            {
                                while (_dataSaveBackgroundWorker.IsBusy)
                                {
                                    Console.WriteLine("data save");
                                    System.Threading.Thread.Sleep(10);
                                }
                                _dataSaveBackgroundWorker.RunWorkerAsync();

                                _dataTresholdCounter = 0;
                                TimeChartRefreshEvent(this);
                            }

                            _fftDataCounter++;
                            if(_fftDataCounter >= _numberOfFFTPoints)
                            {
                                _fftDataCounter = 0;
                                _samplingFreq = 1000.0 / (double)(_currentTime - _previousTime).Milliseconds;

                                while(_fftBackgroundWorker.IsBusy)
                                {
                                    Console.WriteLine("fft");
                                    System.Threading.Thread.Sleep(10);
                                }

                                if (_currentFftAxis == FftAxis.AxisX)
                                {
                                    _xAxisFFTDataArray = _xAxisDataArray;
                                    _xAxisDataArray = new float[_numberOfFFTPoints];
                                }
                                else if (_currentFftAxis == FftAxis.AxisY)
                                {
                                    _yAxisFFTDataArray = _yAxisDataArray;
                                    _yAxisDataArray = new float[_numberOfFFTPoints];
                                }
                                else if (_currentFftAxis == FftAxis.AxisZ)
                                {
                                    _zAxisFFTDataArray = _zAxisDataArray;
                                    _zAxisDataArray = new float[_numberOfFFTPoints];
                                }

                                _currentFftAxis = _fftAxisToChange;

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

        private void _ComputeFFTandSendData(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (_currentFftAxis == FftAxis.AxisX)
            {
                Array.Clear(_imagFFTValues, 0, _numberOfFFTPoints);
                _xAxisFFTDataArray = ComputeRealFFTValues(_fftRank, ref _xAxisFFTDataArray, ref _imagFFTValues, _samplingFreq, ref _freqFTTArray);
            }
            else if (_currentFftAxis == FftAxis.AxisY)
            {
                Array.Clear(_imagFFTValues, 0, _numberOfFFTPoints);
                _yAxisFFTDataArray = ComputeRealFFTValues(_fftRank, ref _yAxisFFTDataArray, ref _imagFFTValues, _samplingFreq, ref _freqFTTArray);
            }
            else if (_currentFftAxis == FftAxis.AxisZ)
            {
                Array.Clear(_imagFFTValues, 0, _numberOfFFTPoints);
                _zAxisFFTDataArray = ComputeRealFFTValues(_fftRank, ref _zAxisFFTDataArray, ref _imagFFTValues, _samplingFreq, ref _freqFTTArray);
            }

            FftChartRefreshEvent(this);
        }

        static public double[] ComputeRealFFTValues(int m, ref double[] realValues, ref double[] imagValues, double sampleFrequency, ref int[] freqValues)
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

        static public float[] ComputeRealFFTValues(int m, ref float[] realValues, ref float[] imagValues, double sampleFrequency, ref int[] freqValues)
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

        static public double[] ComputeRealFFTValues(int m, ref double[] realValues, ref double[] imagValues)
        {
            double[] fftAbsValuesArray = new double[realValues.Length / 2];
            FFTLibrary.Complex.FFT(1, m, realValues, imagValues);

            for (int i = 0; i < realValues.Length / 2; i++)
            {
                fftAbsValuesArray[i] = Math.Sqrt(realValues[i] * realValues[i] + imagValues[i] * imagValues[i]);
            }
            return fftAbsValuesArray;
        }

        static public float[] ComputeRealFFTValues(int m, ref float[] realValues, ref float[] imagValues)
        {
            float[] fftAbsValuesArray = new float[realValues.Length / 2];
            FFTLibrary.Complex.FFT(1, m, realValues, imagValues);

            for (int i = 0; i < realValues.Length / 2; i++)
            {
                fftAbsValuesArray[i] = (float)Math.Sqrt(realValues[i] * realValues[i] + imagValues[i] * imagValues[i]);
            }
            return fftAbsValuesArray;
        }

        private void DataSaveEventCall(object sender, System.ComponentModel.DoWorkEventArgs e)
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
        public void Clear()
        {
            _InitializeComponents();
            Console.WriteLine("Components cleared.");
        }
    }
}
