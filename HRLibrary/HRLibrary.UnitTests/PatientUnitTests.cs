using NUnit.Framework;
using System;
using HRLibrary;

namespace HRLibrary.UnitTests
{
    [TestFixture]
    public class PatientUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var patient = CreateTestPatient();

            Assert.That(patient.Name, Is.EqualTo("Иван"));
            Assert.That(patient.Surname, Is.EqualTo("Иванов"));
            Assert.That(patient.PolicyNumber, Is.EqualTo("111222"));
            Assert.That(patient.Service, Is.EqualTo(PatientServiceType.Insurance));
        }

        [Test]
        public void GetInfoTest()
        {
            var patient = CreateTestPatient();

            patient.AttendingStaff = new Doctor("Алексей", "Смирнов", "Терапия", "Кардиолог");

            var info = patient.GetInfo();

            Assert.That(info.Length, Is.EqualTo(3));
            Assert.That(info[0], Is.EqualTo("Иван Иванов"));
            Assert.That(info[1], Does.Contain("111222"));
            Assert.That(info[2], Does.Contain("Кардиолог"));
        }

        [Test]
        public void PolymorphismNurseTest()
        {
            var patient = CreateTestPatient();

            patient.AttendingStaff = new Nurse("Мария", "Иванова", "Хирургия", "Высшая");

            var info = patient.GetInfo();

            Assert.That(info[2], Does.Contain("Медсестра"));
            Assert.That(info[2], Does.Contain("Высшая"));
        }

        private Patient CreateTestPatient()
        {
            return new Patient("Иван", "Иванов", "111222", PatientServiceType.Insurance);
        }
    }
}