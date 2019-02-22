using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkinson_Recorder.Data_Processing
{
    class PatientData
    {
        public enum Gender { Woman, Man };

        private int _patientID;
        private string _name;
        private string _surname;
        private DateTime _birthDate;
        private Gender _gender;

        public PatientData(string name, string surname, DateTime birthDate, Gender gender)
        {
            _name = name;
            _surname = surname;
            _birthDate = birthDate;
            _gender = gender;
        }

        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public DateTime BirthDate { get => _birthDate; set => _birthDate = value; }
        public Gender GetGender { get => _gender; set => _gender = value; }
        public int PatientID { get => _patientID; set => _patientID = value; }
    }
}
