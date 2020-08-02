using NUnit.Framework;
using CSharpCalculator;
using System;

namespace UnitTestNew
{
    [TestFixture]
    public class SqrtTest : BaseTest
    {
        [Test]
        [Parallelizable(ParallelScope.Self)]
        [TestCaseSource(typeof(SqrtTest), "mas")]
        public void TestSqrt1(double val)
        {
            var sqrt = Calc.Sqrt(val);
            Assert.AreEqual(Math.Sqrt(val), sqrt);
        }
        private static object[] mas = { 
            new object[] { 25 }, 
            new object[] { Double.MaxValue }, 
            new object[] { -25.3 } };

    }
}
