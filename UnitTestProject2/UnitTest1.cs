using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pr3;
using System;

namespace UnitTestProject2
{
    [TestClass]
    public class CalculationABTEST
    {
        [TestMethod]
        public void Calculation_first()
        {
            var calc = new CalculationAB(1, 1000);
            var testRes = 0;
            var res = calc.Sun();
            Assert.AreEqual(testRes, res);
        }


        

    }
}
