using NUnit.Framework;
using CSharpCalculator;
using System;

namespace UnitTestNew
{
    [TestFixture]
    public class IsPositiveTest : BaseTest
    {
        [Test]
        [Parallelizable(ParallelScope.Self)]
        [TestCaseSource(typeof(IsPositiveTest), "mas")]
        public void TestPositive1(double val)
        {
            var isPos = Calc.isPositive(val);
            bool isPosRight = false;
            if (val > 0)
                isPosRight = true;
            Assert.AreEqual(isPosRight, isPos);
        }
        private static object[] mas = { 
            new object[] { -5.5 },
            new object[] { 3 },
            new object[] { Double.MinValue }, 
            new object[] { Double.MaxValue },
            new object[] { 0 } };
    }
}
