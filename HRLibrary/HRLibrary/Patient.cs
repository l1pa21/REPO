using System;

namespace HRLibrary
{
    public class Patient : IComparable<Patient>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public readonly string PolicyNumber;
        public DateTime AdmissionDate { get; set; }
        public DateTime DischargeDate { get; set; }
        public decimal TreatmentCost { get; set; }
        public PatientServiceType Service { get; set; }

        public MedicalWorker AttendingStaff { get; set; }

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
            var info = new string[3];

            info[0] = $"{Name} {Surname}";

            string serviceName = Service == PatientServiceType.Insurance ? "страховое" : "платное";
            info[1] = $"Полис: {PolicyNumber}. Тип: {serviceName}. Поступил: {AdmissionDate:d}.";
            if (AttendingStaff != null)
            {
                info[2] = $"Лечащий персонал: {AttendingStaff.GetInfo()}";
            }
            else
            {
                info[2] = "Персонал не назначен";
            }

            return info;
        }
        // Реализация интерфейса IComparable<Patient>
        public int CompareTo(Patient other)
        {
            if (other == null) return 1;

            int surnameComparison = string.Compare(this.Surname, other.Surname, StringComparison.OrdinalIgnoreCase);
            if (surnameComparison != 0)
            {
                return surnameComparison;
            }

            return string.Compare(this.Name, other.Name, StringComparison.OrdinalIgnoreCase);
        }
        public override bool Equals(object obj)
        {
            if (obj is Patient other)
            {
                return Name == other.Name && Surname == other.Surname && PolicyNumber == other.PolicyNumber;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return $"{Name}_{Surname}_{PolicyNumber}".GetHashCode();
        }
    }
    }
