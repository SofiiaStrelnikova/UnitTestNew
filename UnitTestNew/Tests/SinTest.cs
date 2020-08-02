using NUnit.Framework;
using CSharpCalculator;
using System;

namespace UnitTestNew
{
    [TestFixture]
    public class SinTest : BaseTest
    {
        [Test]
        [Parallelizable(ParallelScope.Self)]
        [TestCaseSource(typeof(SinTest), "mas")]
        public void TestSin1(object val)
        {
            var sin = Calc.Sin(val);
            Assert.AreEqual(Math.Sin((double)val), sin);
        }
        private static object[] mas = { 
            new object[] { Math.PI },  
            new object[] { Math.PI / 2 } 
        };
        
    }
}
