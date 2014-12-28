using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace InterfaceTests
{
    [TestFixture]
    public class InterfaceTests
    {
        [Test]
        public void DanImplementsPerson()
        {
            var dan = new Dan();
            var helper = new Helper();
            var result = helper.Greet(dan);

            Assert.That(result, Is.EqualTo("Hello."));
        }

        [Test]
        public void DanImplementsPerson1()
        {
            var liz = new Liz();
            var helper = new Helper();
            var result = helper.Greet(liz);

            Assert.That(result, Is.EqualTo("Howdy!"));
        }

        [Test]
        public void DanHasAnAge()
        {
            var dan = new Dan();
            dan.Age = 35;
            var helper = new Helper();
            var result = helper.GetAge(dan);

            Assert.That(result, Is.EqualTo(35));
        }

        [Test]
        public void LizHasAnAge()
        {
            var liz = new Dan();
            liz.Age = 20;
            var helper = new Helper();
            var result = helper.GetAge(liz);

            Assert.That(result, Is.EqualTo(20));
        }
    }

    public interface IPerson
    {
        int Age { get; set; }
        string SayHello();
    }

    public class Liz : IPerson
    {
        public int Age {get; set; }
        public string SayHello()
        {
            return "Howdy!";
        }
    }

    public class Dan : IPerson
    {
        public int Age { get; set; }
        public string SayHello()
        {
            return "Hello.";
        }
    }

    public class Helper
    {
        public string Greet(IPerson p)
        {
            return p.SayHello();
        }

        public int GetAge(IPerson p)
        {
            return p.Age;
        }
    }
}
