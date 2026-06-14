using NUnit.Framework;
using System;
using TourLibrary;

namespace TourLibrary.UnitTests
{
    [TestFixture]
    public class TourCodeComparerTests
    {
        [Test]
        public void CompareTest()
        {
            var comparer = new TourCodeComparer();

            var tour1 = new Tour(
                "Анталия",
                "A001",
                "Турция",
                TransportType.Airplane,
                TimeSpan.FromDays(7));

            var tour2 = new Tour(
                "Бодрум",
                "B001",
                "Турция",
                TransportType.Airplane,
                TimeSpan.FromDays(7));

            Assert.That(comparer.Compare(tour1, tour2), Is.LessThan(0));
            Assert.That(comparer.Compare(tour2, tour1), Is.GreaterThan(0));
        }
    }
}