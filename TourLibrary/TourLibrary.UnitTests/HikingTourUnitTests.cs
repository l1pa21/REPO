using NUnit.Framework;
using System;
using TourLibrary;

namespace TourLibrary.UnitTests
{
    [TestFixture]
    public class HikingTourUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var tour = CreateTestTour();

            Assert.That(tour.DifficultyLevel, Is.EqualTo(3));
            Assert.That(tour.HikingType, Is.EqualTo(HikingType.Mountaineering));
        }

        [Test]
        public void GetInfoTest()
        {
            var tour = CreateTestTour();

            var info = tour.GetInfo();

            Assert.That(info.Length, Is.EqualTo(5));
            Assert.That(info[2], Is.EqualTo("Походный тур"));
            Assert.That(info[3], Is.EqualTo("Сложность: 3"));
            Assert.That(info[4], Is.EqualTo("Тип похода: Mountaineering"));

        }

        private HikingTour CreateTestTour()
        {
            return new HikingTour(
                "Эльбрус",
                "EL001",
                "Кавказ",
                TransportType.Train,
                TimeSpan.FromDays(7),
                3,
                HikingType.Mountaineering
            );
        }
    }
}