using NUnit.Framework;
using System;
using TourLibrary;

namespace TourLibrary.UnitTests
{
    [TestFixture]
    public class TourCompareTests
    {
        [Test]
        public void CompareToTest()
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
                TimeSpan.FromDays(7));

            tour1.StartDate = new DateTime(2026, 6, 1);
            tour2.StartDate = new DateTime(2026, 7, 1);

            Assert.That(tour1.CompareTo(tour2), Is.LessThan(0));
            Assert.That(tour2.CompareTo(tour1), Is.GreaterThan(0));
            Assert.That(tour1.CompareTo(tour1), Is.EqualTo(0));
        }
    }
}
