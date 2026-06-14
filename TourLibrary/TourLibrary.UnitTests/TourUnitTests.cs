using NUnit.Framework;
using System;
using TourLibrary;

namespace TourLibrary.UnitTests
{
    [TestFixture]
    public class TourUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var tour = CreateTestTour();

            Assert.That(tour.Name, Is.EqualTo("Турция 2026"));
            Assert.That(tour.Code, Is.EqualTo("TR001"));
            Assert.That(tour.Places, Is.EqualTo("Анталья, Аланья"));
            Assert.That(tour.Transport, Is.EqualTo(TransportType.Airplane));
            Assert.That(tour.Duration, Is.EqualTo(TimeSpan.FromDays(10)));
        }

        [Test]
        public void GetInfoTest()
        {
            var tour = CreateTestTour();

            var info = tour.GetInfo();

            Assert.That(info.Length, Is.EqualTo(2));
            Assert.That(info[0], Is.EqualTo("Турция 2026 (TR001)"));

            Assert.That(
                info[1],
                Is.EqualTo(
                    "Места посещения: Анталья, Аланья. Транспорт: Airplane. Продолжительность: 10 дней."
                ));
        }

        private Tour CreateTestTour()
        {
            return new Tour(
                "Турция 2026",
                "TR001",
                "Анталья, Аланья",
                TransportType.Airplane,
                TimeSpan.FromDays(10));
        }
    }
}