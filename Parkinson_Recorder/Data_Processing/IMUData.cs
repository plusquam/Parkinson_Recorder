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
        private const int _numberOfSensors = 3;
        private int _numberOfChartPoints;

        private int   _byteCounter = 0;
        private int _currentSensor = 0;

        private enum  _DataQueue {Time, AccelX, AccelY, AccelZ, GyroX, GyroY, GyroZ};
        private _DataQueue _currentMeasure = _DataQueue.Time;
        
        private const float _accelMultiplicator = 0.06103516f;
        private const float _gyroMultiplicator = 0.007633588f;

        private uint _dataByteH = 0;

        private System.IO.StreamWriter _fileStream = System.IO.File.CreateText(@"C:\Users\plusq\Desktop\pomiar3.txt");

        private LinkedList<short>  _timeSeries =  new LinkedList<short>();

        private LinkedList<float> _accXSeries = new LinkedList<float>();
        private LinkedList<float> _accYSeries = new LinkedList<float>();
        private LinkedList<float> _accZSeries = new LinkedList<float>();

        private LinkedList<float> _gyroXSeries = new LinkedList<float>();
        private LinkedList<float> _gyroYSeries = new LinkedList<float>();
        private LinkedList<float> _gyroZSeries = new LinkedList<float>();

        public LinkedList<short> TimeSeries { get => _timeSeries; set => _timeSeries = value; }
        public LinkedList<float> AccXSeries { get => _accXSeries; set => _accXSeries = value; }
        public LinkedList<float> AccYSeries { get => _accYSeries; set => _accYSeries = value; }
        public LinkedList<float> AccZSeries { get => _accZSeries; set => _accZSeries = value; }
        public LinkedList<float> GyroXSeries { get => _gyroXSeries; set => _gyroXSeries = value; }
        public LinkedList<float> GyroYSeries { get => _gyroYSeries; set => _gyroYSeries = value; }
        public LinkedList<float> GyroZSeries { get => _gyroZSeries; set => _gyroZSeries = value; }


        public IMUData(int numberOfChartPoints)
        {
            _numberOfChartPoints = numberOfChartPoints;
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
                    Console.Write(tempData);
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
                    float dataValue;

                    switch (_currentMeasure)
                    {
                        case _DataQueue.Time:
                            {
                                _timeSeries.AddLast(tempData);
                                _fileStream.Write(tempData.ToString() + ";");
                                Console.Write( "  " + tempData.ToString() + Environment.NewLine);
                                Console.WriteLine("New measure.");
                                break;
                            }
                        case _DataQueue.AccelX:
                            {
                                dataValue = (float)tempData * _accelMultiplicator;
                                _accXSeries.AddLast(dataValue);
                                _fileStream.Write(dataValue.ToString() + ';');
                                Console.Write("  " + dataValue.ToString() + Environment.NewLine);
                                break;
                            }
                        case _DataQueue.AccelY:
                            {
                                dataValue = (float)tempData * _accelMultiplicator;
                                _accYSeries.AddLast(dataValue);
                                _fileStream.Write(dataValue.ToString() + ";");
                                Console.Write("  " + dataValue.ToString() + Environment.NewLine);
                                break;
                            }
                        case _DataQueue.AccelZ:
                            {
                                dataValue = (float)tempData * _accelMultiplicator;
                                _accZSeries.AddLast(dataValue);
                                _fileStream.Write(dataValue.ToString() + ";");
                                Console.Write("  " + dataValue.ToString() + Environment.NewLine);
                                break;
                            }
                        case _DataQueue.GyroX:
                            {
                                dataValue = (float)tempData * _gyroMultiplicator;
                                _gyroXSeries.AddLast(dataValue);
                                _fileStream.Write(dataValue.ToString() + ";");
                                Console.Write("  " + dataValue.ToString() + Environment.NewLine);
                                break;
                            }
                        case _DataQueue.GyroY:
                            {
                                dataValue = (float)tempData * _gyroMultiplicator;
                                _gyroYSeries.AddLast(dataValue);
                                _fileStream.Write(dataValue.ToString() + ";");
                                Console.Write("  " + dataValue.ToString() + Environment.NewLine);
                                break;
                            }   
                        case _DataQueue.GyroZ:
                            {
                                dataValue = (float)tempData * _gyroMultiplicator;
                                _gyroZSeries.AddLast(dataValue);
                                _fileStream.Write(dataValue.ToString() + ";");
                                Console.Write("  " + dataValue.ToString() + Environment.NewLine);
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
                        Console.WriteLine("Next sensor");
                        if (_currentSensor >= _numberOfSensors)
                        {
                            _currentSensor = 0;
                            _currentMeasure = _DataQueue.Time;
                            _dataByteH = 0;
                            _fileStream.Write(Environment.NewLine);
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
