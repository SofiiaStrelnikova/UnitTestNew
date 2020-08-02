using NUnit.Framework;
using System;

namespace UnitTestNew
{
    [TestFixture]
    public class TestCos : BaseTest
    {
        [Test]
        [Parallelizable(ParallelScope.Self)]
        [TestCaseSource(typeof(TestCos), "mas")]
        public void TestCos1(double val)
        {
            var cos = Calc.Cos(val);
            Assert.AreEqual(Math.Cos(val), cos);
        }
        private static object[] mas = { 
            new object[] { Math.PI },  
            new object[] { -Math.PI / 2 } };
        
    }
}
