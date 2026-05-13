using System;

namespace HRLibrary
{
    public class Patient
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public readonly string PolicyNumber;

        public DateTime AdmissionDate { get; set; }
        public DateTime DischargeDate { get; set; }
        public decimal TreatmentCost { get; set; }
        public PatientServiceType Service { get; set; }

        public Patient(string name, string surname, string policyNumber, PatientServiceType service)
        {
            Name = name;
            Surname = surname;
            PolicyNumber = policyNumber;
            Service = service;
            AdmissionDate = DateTime.Now;
        }

        public virtual string[] GetInfo()
        {
            var info = new string[2];
            info[0] = $"{Name} {Surname}";

            string serviceName = Service == PatientServiceType.Insurance ? "страховое" : "платное";

            info[1] = $"Полис: {PolicyNumber}. Тип: {serviceName}. Поступил: {AdmissionDate:d}.";
            return info;
        }
    }
}