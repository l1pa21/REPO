using NUnit.Framework;
using System;
using PhoneCallStruct;

namespace PhoneCallStruct.UnitTests
{
    [TestFixture]
    public class PhoneCallTests
    {
        [Test]
        public void ConstructorTest()
        {
            var call = new PhoneCall(120, 2.5);

            Assert.That(call.Time, Is.EqualTo(120));
            Assert.That(call.Rate, Is.EqualTo(2.5).Within(1e-10));
        }

        [TestCase(0)]
        [TestCase(-10)]
        public void TimeSet_WrongValue_ArgumentException(int value)
        {
            var call = new PhoneCall();

            Assert.That(() => call.Time = value,
                Throws.ArgumentException);
        }

        [TestCase(0)]
        [TestCase(-2.5)]
        public void RateSet_WrongValue_ArgumentException(double value)
        {
            var call = new PhoneCall();

            Assert.That(() => call.Rate = value,
                Throws.ArgumentException);
        }

        [TestCase(60, 2.5, 2.5)]
        [TestCase(120, 3.0, 6.0)]
        [TestCase(30, 4.0, 2.0)]
        public void CostTest(int time, double rate, double result)
        {
            var call = new PhoneCall(time, rate);

            Assert.That(call.Cost,
                Is.EqualTo(result).Within(1e-10));
        }

        [TestCase(120, 2.5, "Разговор: 120 c по 2.5 руб./мин")]
        [TestCase(60, 4, "Разговор: 60 c по 4 руб./мин")]
        public void ToStringTest(int time, double rate, string result)
        {
            var call = new PhoneCall(time, rate);

            Assert.That(call.ToString(),
                Is.EqualTo(result));
        }

        [Test]
        public void Equals_TwoCalls_True()
        {
            var a = new PhoneCall(120, 2.5);
            var b = new PhoneCall(120, 2.5);

            Assert.That(a.Equals(b), Is.True);
        }

        [Test]
        public void Equals_TwoCalls_False()
        {
            var a = new PhoneCall(120, 2.5);
            var b = new PhoneCall(130, 2.5);

            Assert.That(a.Equals(b), Is.False);
        }

        [Test]
        public void Equals_WrongArgument_ArgumentException()
        {
            var call = new PhoneCall(120, 2.5);

            Assert.That(() => call.Equals("test"),
                Throws.ArgumentException);
        }

        [Test]
        public void GetHashCodeTest()
        {
            var a = new PhoneCall(120, 2.5);
            var b = new PhoneCall(120, 2.5);

            Assert.That(a.GetHashCode(),
                Is.EqualTo(b.GetHashCode()));
        }

        [Test]
        public void ComparisonOperatorsTest()
        {
            var a = new PhoneCall(120, 2.5);
            var b = new PhoneCall(120, 2.5);
            var c = new PhoneCall(60, 2.5);

            Assert.That(a == b, Is.True);
            Assert.That(a != c, Is.True);
        }

        [Test]
        public void AdditionTest()
        {
            var a = new PhoneCall(120, 2.5);
            var b = new PhoneCall(60, 2.5);

            var result = a + b;

            Assert.That(result.Time, Is.EqualTo(180));
            Assert.That(result.Rate,
                Is.EqualTo(2.5).Within(1e-10));
        }

        [Test]
        public void Addition_DifferentRates_ArgumentException()
        {
            var a = new PhoneCall(120, 2.5);
            var b = new PhoneCall(60, 3.0);

            Assert.That(() => a + b,
                Throws.ArgumentException);
        }

        [Test]
        public void MultiplicationTest()
        {
            var call = new PhoneCall(120, 2.5);

            var result = call * 2;

            Assert.That(result.Time, Is.EqualTo(120));
            Assert.That(result.Rate,
                Is.EqualTo(5.0).Within(1e-10));
        }

        [Test]
        public void Multiplication_WrongCoefficient_ArgumentException()
        {
            var call = new PhoneCall(120, 2.5);

            Assert.That(() => call * -2,
                Throws.ArgumentException);
        }
    }
}