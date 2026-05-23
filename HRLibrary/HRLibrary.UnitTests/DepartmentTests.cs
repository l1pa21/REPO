using NUnit.Framework;
using System.Collections.Generic;

namespace HRLibrary.UnitTests
{
    [TestFixture]
    public class DepartmentTests
    {
        private Patient p1;
        private Patient p2;
        private Patient p3;
        private Patient p4;

        [SetUp]
        public void Setup()
        {
            p1 = new Patient("Иван", "Иванов", "1111", PatientServiceType.Insurance);
            p2 = new Patient("Алексей", "Иванов", "3333", PatientServiceType.Insurance);
            p3 = new Patient("Анна", "Смирнова", "2222", PatientServiceType.Insurance);
            p4 = new Patient("Иван", "Иванов", "1111", PatientServiceType.Insurance); 
        }

        [Test]
        public void Patient_CompareTo_SortsCorrectly()
        {
            Assert.That(p1.CompareTo(p3), Is.LessThan(0)); 
            Assert.That(p2.CompareTo(p1), Is.LessThan(0)); 
            Assert.That(p1.CompareTo(p4), Is.EqualTo(0));  
        }

        [Test]
        public void PatientPolicyComparer_SortsCorrectly()
        {
            var comparer = new PatientPolicyComparer();
            Assert.That(comparer.Compare(p1, p3), Is.LessThan(0)); 
            Assert.That(comparer.Compare(p2, p3), Is.GreaterThan(0)); 
        }

        [Test]
        public void Department_RemovesDuplicates_And_CountCorrect()
        {
            var patients = new List<Patient> { p1, p2, p3, p4 };
            var department = new Department("Терапия", patients);

            Assert.That(department.Title, Is.EqualTo("Терапия"));
            Assert.That(department.Count, Is.EqualTo(3)); 
        }

        [Test]
        public void Department_IEnumerable_Works()
        {
            var patients = new List<Patient> { p1, p2 };
            var department = new Department("Хирургия", patients);

            var resultList = new List<Patient>();
            foreach (var p in department)
            {
                resultList.Add(p);
            }

            Assert.That(resultList.Count, Is.EqualTo(2));
        }
    }
}