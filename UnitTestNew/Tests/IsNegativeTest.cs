using NUnit.Framework;
using CSharpCalculator;
using System;

namespace UnitTestNew
{
    [TestFixture]
    public class IsNegativeTest : BaseTest
    {
        [Test]
        [Parallelizable(ParallelScope.Self)]
        [TestCaseSource(typeof(IsNegativeTest), "mas")]
        public void TestNegative1(double val)
        {            
            var isNeg = Calc.isNegative(val);
            bool isNegRight = false;
            if (val < 0)
                isNegRight = true;
            Assert.AreEqual(isNegRight, isNeg);
        }

        private static object[] mas = { 
            new object[] { -5.25 }, 
            new object[] { 25 }, 
            new object[] { Double.MinValue }, 
            new object[] { Double.MaxValue },
            new object[] { 0 } };
    }
}
