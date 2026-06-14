using NUnit.Framework;
using System;
using TourLibrary;

namespace TourLibrary.UnitTests
{
    [TestFixture]
    public class ForeignTourUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var tour = CreateTestTour();

            Assert.That(tour.Country, Is.EqualTo("Турция"));
            Assert.That(tour.VisaRequired, Is.EqualTo(true));
            Assert.That(tour.VisaCost, Is.EqualTo(5000));
        }

        [Test]
        public void GetInfoTest()
        {
            var tour = CreateTestTour();

            var info = tour.GetInfo();

            Assert.That(info.Length, Is.EqualTo(5));
            Assert.That(info[2], Is.EqualTo("Зарубежный тур"));
            Assert.That(info[3], Is.EqualTo("Страна: Турция"));
            Assert.That(info[4], Is.EqualTo("Требуется виза: True"));
        }

        private ForeignTour CreateTestTour()
        {
            var tour = new ForeignTour(
                "Анталия 2026",
                "TR001",
                "Анталия",
                TransportType.Airplane,
                TimeSpan.FromDays(10),
                "Турция"
            );

            tour.VisaRequired = true;
            tour.VisaCost = 5000;

            return tour;
        }
    }
}
