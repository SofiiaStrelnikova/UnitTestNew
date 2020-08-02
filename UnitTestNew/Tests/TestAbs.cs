using CSharpCalculator;
using System;
using NUnit.Framework;

namespace UnitTestNew
{
    [TestFixture]
    public class TestAbs : BaseTest
    {
        [Test]
        [Parallelizable(ParallelScope.Self)]
        [TestCaseSource(typeof(TestAbs), "mas")]
        public void TestAbs1(double val)
        {          
            var abs = Calc.Abs(val);
            Assert.AreEqual(Math.Abs(val), abs);
        }
        private static object[] mas = {
            new object[] { 0 },
            new object[] { 7 },
            new object[] { -25 }, 
            new object[] { Double.MinValue }, 
            new object[] { Double.MaxValue } 
        };
    }
}
