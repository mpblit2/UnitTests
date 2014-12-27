using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace exception
{
    public class Calc
    {
        public double Divide(int x, int y)
        {
            return x / y;
        }
    }

    [TestFixture]
    public class CalsTests
    {
        [Test]
        public void DivideByZeroThrowsException1()
        {
            Calc c = new Calc();

            Assert.Throws<DivideByZeroException>(delegate { c.Divide(2, 0); });
        }

        [Test]
        [ExpectedException(ExpectedException = typeof(DivideByZeroException))]
        public void DivideByZeroThrowsException2()
        {
            Calc c = new Calc();

            double result = c.Divide(2, 0);
        }

        [Test]
        public void DivideByZeroThrowsException3()
        {
            Calc c = new Calc();

            //double result = c.Divide(2, 0);

            Assert.That(delegate { c.Divide(2, 0); }, Throws.Exception.TypeOf<DivideByZeroException>());
        }

    }
}
