using NUnit.Framework;
using CSharpCalculator;
using System;

namespace UnitTestNew
{
    [TestFixture]
    public class SubtructTest : BaseTest
    {
        [Test]
        [Parallelizable(ParallelScope.Self)]
        [TestCaseSource(typeof(SubtructTest), "mas")]
        public void TestSubtract1(double val1, double val2)
        {
            var sub = Calc.Sub(val1, val2);
            Assert.AreEqual(val1 - val2, sub);
        }
        private static object[] mas = { 
            new object[] { 1000.25, -10 },
            new object[] { 10, 10 },
            new object[] { Double.MaxValue, 550 } 
        };
    }
}
