using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace BasicUnitTests
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
        [Test]
        public void AddReturnsSumOfBothParams()
        {
            Sample s = new Sample();

            int result = s.Add(1, 1);

            Assert.AreEqual(2, result);
        }
    }
}
