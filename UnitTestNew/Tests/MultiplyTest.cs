using NUnit.Framework;
using CSharpCalculator;
using System;

namespace UnitTestNew
{
    [TestFixture]
    public class MultiplyTest : BaseTest
    {
        [Test]
        [Parallelizable(ParallelScope.Self)]
        [TestCaseSource(typeof(MultiplyTest), "mas")]
        public void TestMultiply1(double val1, double val2)
        {
            var mult = Calc.Multiply(val1, val2);
            Assert.AreEqual(val1 * val2, mult);
        }
        private static object[] mas = { 
            new object[] { -5, 5.25 },
            new object[] { 3, 2 },
            new object[] { Double.MinValue, 100 } };
    }
}
