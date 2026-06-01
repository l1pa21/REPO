namespace HRLibrary
{
    public class Nurse : MedicalWorker
    {
        public string Category { get; set; } // Категория (первая, высшая и т.д.)

        public Nurse(string name, string surname, string department, string category)
            : base(name, surname, department)
        {
            Category = category;
        }

        public override string GetInfo()
        {
            return $"Медсестра: {Name} {Surname}, категория: {Category}, отд.: {Department}";
        }
    }
}