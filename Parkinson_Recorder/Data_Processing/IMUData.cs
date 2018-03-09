#define TEST_FILE

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkinson_Recorder.Data_Processing
{
    class IMUData
    {
        private const int _numberOfSensors = 2;
        private int _numberOfChartPoints;

        private int   _byteCounter = 0;
        private int _currentSensor = 0;

        private enum  _DataQueue {Time, AccelX, AccelY, AccelZ, GyroX, GyroY, GyroZ};
        private _DataQueue _currentMeasure = _DataQueue.Time;
        
        private const double _accelMultiplicator = 0.06103516;
        private const double _gyroMultiplicator = 0.007633588;

        private uint _dataByteH = 0;

        private System.IO.StreamWriter _fileStream = System.IO.File.CreateText(@"C:\Users\plusq\Desktop\pomiar3.txt");

        private LinkedList<short>  _timeSeries =  new LinkedList<short>();

        private LinkedList<double> _accXSeries = new LinkedList<double>();
        private LinkedList<double> _accYSeries = new LinkedList<double>();
        private LinkedList<double> _accZSeries = new LinkedList<double>();

        private LinkedList<double> _gyroXSeries = new LinkedList<double>();
        private LinkedList<double> _gyroYSeries = new LinkedList<double>();
        private LinkedList<double> _gyroZSeries = new LinkedList<double>();

        public LinkedList<short> TimeSeries { get => _timeSeries; set => _timeSeries = value; }
        public LinkedList<double> AccXSeries { get => _accXSeries; set => _accXSeries = value; }
        public LinkedList<double> AccYSeries { get => _accYSeries; set => _accYSeries = value; }
        public LinkedList<double> AccZSeries { get => _accZSeries; set => _accZSeries = value; }
        public LinkedList<double> GyroXSeries { get => _gyroXSeries; set => _gyroXSeries = value; }
        public LinkedList<double> GyroYSeries { get => _gyroYSeries; set => _gyroYSeries = value; }
        public LinkedList<double> GyroZSeries { get => _gyroZSeries; set => _gyroZSeries = value; }


        public IMUData(int numberOfChartPoints)
        {
            _numberOfChartPoints = numberOfChartPoints;

            short a = 1235;
            double b = (double)a * 0.0001f;

            Console.WriteLine(b);
        }

        public void DataReceived(byte[] data)
        {
            foreach ( byte currentByte in data)
            {
#if TEST_FILE
                if (_byteCounter % 4 == 3)
                {
                    short tempData = (short)((_dataByteH << 4) + getHexFromAsciiChar(currentByte));
                    Console.Write(getHexFromAsciiChar(currentByte) + " -> ");
                    Console.Write(tempData + Environment.NewLine);
#else
                if (_byteCounter % 2 == 1)
                {
                    short tempData = (short)((_dataByteH << 8 ) + currentByte );
#endif

                    while (_timeSeries.Count >= _numberOfChartPoints && _gyroZSeries.Count >= _numberOfChartPoints && _timeSeries.Count != 0)
                    {
                        _timeSeries.RemoveFirst();
                        _accXSeries.RemoveFirst();
                        _accYSeries.RemoveFirst();
                        _accZSeries.RemoveFirst();
                        _gyroXSeries.RemoveFirst();
                        _gyroYSeries.RemoveFirst();
                        _gyroZSeries.RemoveFirst();
                    }

                    //_fileStream.Write(tempData.ToString() + ';');

                    switch (_currentMeasure)
                    {
                        case _DataQueue.Time:
                            {
                                _timeSeries.AddLast(tempData);
                                _fileStream.Write(tempData.ToString() + ";");
                                break;
                            }
                        case _DataQueue.AccelX:
                            {
                                _accXSeries.AddLast((double)tempData * _accelMultiplicator);
                                _fileStream.Write(((double)tempData * _accelMultiplicator).ToString() + ';');
                                break;
                            }
                        case _DataQueue.AccelY:
                            {
                                _accYSeries.AddLast((double)tempData * _accelMultiplicator);
                                _fileStream.Write(((double)tempData * _accelMultiplicator).ToString() + ";");
                                break;
                            }
                        case _DataQueue.AccelZ:
                            {
                                _accZSeries.AddLast((double)tempData * _accelMultiplicator);
                                _fileStream.Write(((double)tempData * _accelMultiplicator).ToString() + ";");
                                break;
                            }
                        case _DataQueue.GyroX:
                            {
                                _gyroXSeries.AddLast((double)tempData * _gyroMultiplicator);
                                _fileStream.Write(((double)tempData * _gyroMultiplicator).ToString() + ";");
                                break;
                            }
                        case _DataQueue.GyroY:
                            {
                                _gyroYSeries.AddLast((double)tempData * _gyroMultiplicator);
                                _fileStream.Write(((double)tempData * _gyroMultiplicator).ToString() + ";");
                                break;
                            }   
                        case _DataQueue.GyroZ:
                            {
                                _gyroZSeries.AddLast((double)tempData * _gyroMultiplicator);
                                _fileStream.Write(((double)tempData * _gyroMultiplicator).ToString() + ";");
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
                        if (_currentSensor >= _numberOfSensors)
                        {
                            _currentSensor = 0;
                            _currentMeasure = _DataQueue.Time;
                            _dataByteH = 0;
                            _fileStream.Write(Environment.NewLine);
                            Console.WriteLine("Next sensor");
                        }
                        else
                            _currentMeasure = _DataQueue.AccelX;
                    }
                }
                else
                {
#if TEST_FILE
                    _dataByteH = (_dataByteH << 4) + (uint)getHexFromAsciiChar(currentByte);
                    Console.Write(getHexFromAsciiChar(currentByte).ToString() + "|");
#else
                    _dataByteH = currentByte;
#endif
                }

                _byteCounter++;
            }
        }

#if TEST_FILE
        private byte getHexFromAsciiChar(byte inChar)
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
