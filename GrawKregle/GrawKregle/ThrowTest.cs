using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace GrawKregleTests
{
    [TestFixture]
    public class ThrowTest
    {
        [Test]
        public void TestScoreNoThrows()
        {
            Frame f = new Frame();

            //Assert.AreEqual(0, f.Score);
            Assert.That(f.Score, Is.EqualTo(0));
        }

        [Test]
        public void TestAddOneThrow()
        {
            Frame f = new Frame();
            f.Add(5);

            Assert.That(f.Score, Is.EqualTo(5));
        }
    }

    public class Frame
    {
        private int score;

        public int Score
        {
            get { return score; }
        }

        public void Add(int pins)
        {
            score += pins;
        }
    }
}
