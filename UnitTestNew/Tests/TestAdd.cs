using NUnit.Framework;
using CSharpCalculator;
using System;

namespace UnitTestNew
{
    [TestFixture]
    public class TestAdd : BaseTest
    {
        [Test]
        [Parallelizable(ParallelScope.Self)]
        [TestCaseSource(typeof(TestAdd), "mas")]
        public void TestAdd1(double val1, double val2)
        {
            var addition = Calc.Add(val1, val2);
            Assert.AreEqual(val1 + val2, addition);
        }
        private static object[] mas = { 
            new object[] { 5.0, 3.0 },
            new object[] { 5, 3 },
            new object[] { Double.MinValue, 10000 } };
    }
}
