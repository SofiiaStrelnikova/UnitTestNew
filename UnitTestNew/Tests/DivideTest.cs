using NUnit.Framework;
using CSharpCalculator;
using System;

namespace UnitTestNew
{
    [TestFixture]
    public class DivideTest : BaseTest
    {
        [Test]
        [Parallelizable(ParallelScope.Self)]
        [TestCaseSource(typeof(DivideTest), "mas")]
        public void TestDivide1(double val1, double val2)
        {
            var div = Calc.Divide(val1, val2);
            Assert.AreEqual(val1 / val2, div);
        }

        private static object[] mas = {
            new object[] { -1000, 5 },
            new object[] { -1000, 5.25 }, 
            new object[] { Double.MaxValue, 100,5 }
        };

    }
}
