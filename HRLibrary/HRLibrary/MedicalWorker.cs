using System;

namespace HRLibrary
{
    public abstract class MedicalWorker
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; } // Отделение

        public MedicalWorker(string name, string surname, string department)
        {
            Name = name;
            Surname = surname;
            Department = department;
        }
        public abstract string GetInfo();
    }
}