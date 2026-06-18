using NUnit.Framework;
using Vector2DStruct;

namespace Vector2DStruct.UnitTests
{
    [TestFixture]
    public class Vector2DTests
    {
        [Test]
        public void ConstructorTest()
        {
            var v = new Vector2D(3, 4);

            Assert.That(v.X, Is.EqualTo(3));
            Assert.That(v.Y, Is.EqualTo(4));
        }

        [Test]
        public void LengthTest()
        {
            var v = new Vector2D(3, 4);

            Assert.That(v.Length, Is.EqualTo(5).Within(0.0001));
        }

        [Test]
        public void AddTest()
        {
            var a = new Vector2D(1, 2);
            var b = new Vector2D(3, 4);

            var result = a + b;

            Assert.That(result.X, Is.EqualTo(4));
            Assert.That(result.Y, Is.EqualTo(6));
        }

        [Test]
        public void SubtractTest()
        {
            var a = new Vector2D(5, 7);
            var b = new Vector2D(2, 3);

            var result = a - b;

            Assert.That(result.X, Is.EqualTo(3));
            Assert.That(result.Y, Is.EqualTo(4));
        }

        [Test]
        public void MultiplyByNumberTest()
        {
            var v = new Vector2D(2, 3);

            var result = v * 2;

            Assert.That(result.X, Is.EqualTo(4));
            Assert.That(result.Y, Is.EqualTo(6));
        }

        [Test]
        public void NumberMultiplyVectorTest()
        {
            var v = new Vector2D(2, 3);

            var result = 2 * v;

            Assert.That(result.X, Is.EqualTo(4));
            Assert.That(result.Y, Is.EqualTo(6));
        }

        [Test]
        public void ScalarProductTest()
        {
            var a = new Vector2D(1, 2);
            var b = new Vector2D(3, 4);

            double result = a * b;

            Assert.That(result, Is.EqualTo(11));
        }

        [Test]
        public void EqualityTest()
        {
            var a = new Vector2D(5, 6);
            var b = new Vector2D(5, 6);

            Assert.That(a == b, Is.True);
        }

        [Test]
        public void InequalityTest()
        {
            var a = new Vector2D(5, 6);
            var b = new Vector2D(1, 2);

            Assert.That(a != b, Is.True);
        }
    }
}