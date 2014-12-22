using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace demo
{
    class Sample
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public bool IsTestingFun()
        {
            return true;
        }
    }

    [TestFixture]
    public class SampleTest
    {
        [TestCase(1, 1)]
        [TestCase(-1, -1)]
        [TestCase(-1, 1)]
        [TestCase(1, -1)]
        public void AddReturnsSumOfBothParams(int a, int b)
        {
            Sample s = new Sample();
            int result = s.Add(a, b);

            int expected = a + b;
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsTestingFunReturnsTure()
        {
            Sample s = new Sample();
            bool result = s.IsTestingFun();

            Assert.AreEqual(true, result);
        }
    }
}
