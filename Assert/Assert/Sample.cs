using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace assert
{
    [TestFixture]
    class Sample
    {
        [Test]
        public void AreEqualTest()
        {
            var expected = 5;
            var actual = 5;

            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void AreNotEqualTest()
        {
            var startValue = 5;
            var actual = 50;

            Assert.AreNotEqual(startValue, actual);
        }

        [Test]
        public void IsTrueTest()
        {
            var value = true;

            Assert.IsTrue(value);
        }

        [Test]
        public void IsNullTest()
        {
            string value = null;

            Assert.IsNull(value);
        }

        [Test]
        public void IsNotNullTest()
        {
            string value = string.Empty;

            Assert.IsNotNull(value);
        }

        [Test]
        public void IsNullOrEmptyTest()
        {
            string value = null;

            Assert.IsNullOrEmpty(value);
        }

        [Test]
        public void ContainsTest()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 5 };
            var actual = 5;

            Assert.Contains(actual, numbers);
        }

        [Test]
        public void ThatIsEqualTest()
        {
            var expected = 5;
            var actual = 5;

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ThatIsNotEqualTest()
        {
            var expected = 5;
            var actual = 4;

            Assert.That(actual, Is.Not.EqualTo(expected));
        }

        [Test]
        public void ThatIsTrueTest()
        {
            var actual = true;

            Assert.That(actual, Is.True);
        }

        [Test]
        public void ThatIsFalseTest()
        {
            var actual = false;

            Assert.That(actual, Is.False);
        }

        [Test]
        public void ThatIsNullTest()
        {
            string val = null;

            Assert.That(val, Is.Null);
        }

        [Test]
        public void ThatIsNotNullTest()
        {
            string val = string.Empty;

            Assert.That(val, Is.Not.Null);
        }

        [Test]
        public void ThatHasMemberTest()
        {
            var numbers = new List<int> { 6, 7, 8, 9 };
            var actual = 7;

            Assert.That(numbers, Has.Member(actual));
        }
    }
}
