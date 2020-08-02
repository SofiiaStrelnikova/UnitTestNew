using NUnit.Framework;
using CSharpCalculator;
using System;

namespace UnitTestNew
{
    [TestFixture]
    public class PowTest : BaseTest
    {
        [Test]
        [Parallelizable(ParallelScope.Self)]
        [TestCaseSource(typeof(PowTest), "mas")]
        public void TestPow1(double val1, double val2)
        {
            var pow = Calc.Pow(val1, val2);
            Assert.AreEqual(Math.Pow(val1, val2), pow);
        }
        private static object[] mas = { 
            new object[] { 2, 5 }, 
            new object[] { -10, 3 },
            new object[] { 10, -3 }
        };
    }
}
