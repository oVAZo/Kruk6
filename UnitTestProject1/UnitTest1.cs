using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Pr3;

namespace UnitTestProject1
{
    [TestClass]
    public class Calculation_First_TEST
    {
        [TestMethod]
        public void Calculation_all_b5()
        {
            var calc = new Calculation_abc(7, 2, 2);
            int testRes = 1331;
            int res = calc.CalculateResult();
            Assert.AreEqual(testRes, res);
        }
        [TestMethod]
        public void Calculation_other()
        {
            var calc = new Calculation_abc(2, 2, 2);
            int testRes = 6;
            int res = calc.CalculateResult();
            Assert.AreEqual(testRes, res);
        }
    }
}
