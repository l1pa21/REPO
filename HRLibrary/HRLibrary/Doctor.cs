namespace HRLibrary
{
    public class Doctor : MedicalWorker 
    {
        public string Specialization { get; set; }

        public Doctor(string name, string surname, string department, string specialization)
            : base(name, surname, department) 
        {
            Specialization = specialization;
        }

        public override string GetInfo() 
        {
            return $"Врач: {Name} {Surname}, специализация: {Specialization}, отд.: {Department}";
        }
    }
}