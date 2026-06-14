using NUnit.Framework;
using System;
using TourLibrary;

namespace TourLibrary.UnitTests
{
    [TestFixture]
    public class TravelAgencyTests
    {
        private TravelAgency agency;
        private Tour[] tours;

        [SetUp]
        public void Setup()
        {
            var tour1 = new Tour(
                "Анталия",
                "TR001",
                "Турция",
                TransportType.Airplane,
                TimeSpan.FromDays(7));

            var tour2 = new Tour(
                "Бодрум",
                "TR002",
                "Турция",
                TransportType.Airplane,
                TimeSpan.FromDays(10));

            tours = new Tour[]
            {
                tour1,
                tour2,
                tour1
            };

            agency = new TravelAgency(
                "Мир Туров",
                "Екатеринбург",
                tours);
        }

        [Test]
        public void CountTest()
        {
            Assert.That(agency.Count, Is.EqualTo(2));
        }

        [Test]
        public void IEnumerableTest()
        {
            int count = 0;

            foreach (var tour in agency)
            {
                count++;
            }

            Assert.That(count, Is.EqualTo(2));
        }
    }
}
