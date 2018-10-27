﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parkinson_Recorder.Data_Processing
{
    class PatientData
    {
        public enum Gender { Woman, Man };

        private string _name;
        private string _surname;
        private DateTime _birthDate;
        private Gender _currentGender;

        public PatientData(string name, string surname, DateTime birthDate, Gender gender)
        {
            _name = name;
            _surname = surname;
            _birthDate = birthDate;
            _currentGender = gender;
        }

        public string Name { get => _name; set => _name = value; }
        public string Surname { get => _surname; set => _surname = value; }
        public DateTime BirthDate { get => _birthDate; set => _birthDate = value; }
        internal Gender CurrentGender { get => _currentGender; set => _currentGender = value; }
    }
}
