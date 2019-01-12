using IniParser;
using IniParser.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkinson_Recorder
{
    struct ProgramConfigData
    {
        // Selected paths history
        public string tempMeasurementFilePath;

        // Serial config data
        public string selectedPort;
        public string selectedBaudrate;

        // Charts config data
        public int numberOfPointsInChart;
        public int numberOfFftPoints;

        // Patient data history
        public int numberOfPatients;
        public List<Data_Processing.PatientData> PatientDataHistory;
    };

    class ProgramConfig
    {
        private struct IniSections
        {
            public const string PATHS = "PATHS";
            public const string SERIAL = "SERIAL";
            public const string CHARTS = "CHARTS";
            public const string PATIENTS = "PATIENTS";
        };

        private string _configFilename = @".\data\program_config.ini";
        private FileIniDataParser _fileIniData = new FileIniDataParser();
        private ProgramConfigData _data = new ProgramConfigData();

        public ProgramConfig()
        {
            if (!Directory.Exists(@".\data"))
            {
                Directory.CreateDirectory(@".\data");
                Console.WriteLine("Config directory created.");
            }

            if (File.Exists(_configFilename))
            {
                IniData parsedData = _fileIniData.ReadFile(_configFilename);

                _data.tempMeasurementFilePath = parsedData.Sections[IniSections.PATHS].GetKeyData("tempMeasurementFilePath").Value;

                _data.selectedPort = parsedData.Sections[IniSections.SERIAL].GetKeyData("selectedPort").Value;
                _data.selectedBaudrate = parsedData.Sections[IniSections.SERIAL].GetKeyData("selectedBaudrate").Value;

                _data.numberOfPointsInChart = int.Parse(parsedData.Sections[IniSections.CHARTS].GetKeyData("numberOfPointsInChart").Value);
                _data.numberOfFftPoints = int.Parse(parsedData.Sections[IniSections.CHARTS].GetKeyData("numberOfFftPoints").Value);

                _data.numberOfPatients = int.Parse(parsedData.Sections[IniSections.PATIENTS].GetKeyData("numberOfPatients").Value);

                for(int i = 0; i < _data.numberOfPatients; i++)
                {
                    //TODO
                    //_data.PatientDataHistory.Add();
                }

                Console.WriteLine("Config file read.");
            }
            else
            {
                CreateConfigFile();
            }
        }

        internal ProgramConfigData Data { get => _data; set => _data = value; }

        private bool CreateConfigFile()
        {
            IniData dataToParse = new IniData();

            dataToParse.Sections.AddSection(IniSections.PATHS);
            dataToParse.Sections[IniSections.PATHS].AddKey("tempMeasurementFilePath", @".\data\TempFile.csv");

            dataToParse.Sections.AddSection(IniSections.SERIAL);
            //dataToParse.Sections[IniSections.SERIAL].AddKey("selectedPort", "");
            dataToParse.Sections[IniSections.SERIAL].AddKey("selectedBaudrate", "115200");

            dataToParse.Sections.AddSection(IniSections.CHARTS);
            dataToParse.Sections[IniSections.CHARTS].AddKey("numberOfPointsInChart", "128");
            dataToParse.Sections[IniSections.CHARTS].AddKey("numberOfFftPoints", "64");

            dataToParse.Sections.AddSection(IniSections.PATIENTS);
            dataToParse.Sections[IniSections.PATIENTS].AddKey("numberOfPatients", "0");

            _fileIniData.WriteFile(_configFilename, dataToParse);

            Console.WriteLine("Config file created.");

            return true;
        }
    }
}
