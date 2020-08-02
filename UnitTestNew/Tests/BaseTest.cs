using CSharpCalculator;
using NUnit.Framework;
using System.ComponentModel;

namespace UnitTestNew
{
    [TestFixture]
    public class BaseTest
    {
        private Calculator calc;
        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        public Calculator Calc => calc;
    }
}
