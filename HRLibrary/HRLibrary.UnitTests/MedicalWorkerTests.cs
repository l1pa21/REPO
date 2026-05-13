using NUnit.Framework;
using HRLibrary;

namespace HRLibrary.UnitTests
{
    [TestFixture]
    public class MedicalWorkerTests
    {
        [Test]
        public void DoctorInfoTest()
        {
            var doctor = new Doctor("Алексей", "Смирнов", "Терапия", "Кардиолог");
            Assert.That(doctor.GetInfo(), Does.Contain("Кардиолог"));
        }

        [Test]
        public void NurseInfoTest()
        {
            var nurse = new Nurse("Мария", "Иванова", "Хирургия", "Высшая");
            Assert.That(nurse.GetInfo(), Does.Contain("Медсестра"));
        }

        [Test]
        public void PolymorphismTest()
        {
            MedicalWorker[] staff = new MedicalWorker[]
            {
                new Doctor("Дмитрий", "Петров", "ЛОР", "Отоларинголог"),
                new Nurse("Анна", "Сидорова", "ЛОР", "Первая")
            };

            Assert.That(staff[0].GetInfo(), Does.StartWith("Врач"));
            Assert.That(staff[1].GetInfo(), Does.StartWith("Медсестра"));
        }
    }
}