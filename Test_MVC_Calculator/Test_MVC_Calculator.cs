using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC_Calc;

namespace Test_MVC_Calculator
{
    [TestClass]
    public class Test_MVC_Calculator
    {
        Calc_Controller c = new Calc_Controller();

        [TestMethod]
        public void MultiplicateTwoPositiveNumber()
        {
            int result;
            result = c.mul(10, 5);
            Assert.AreEqual(50m, result, "Multiplication of two positive number failed");
        }

        [TestMethod]
        public void MultiplicationOnePositiveOneNegativeNumber()
        {
            int result;
            result = c.mul(-10, 5);
            Assert.AreEqual(-50m, result, "Multiplication of one positive one negative number failed");
        }

        [TestMethod]
        public void MultiplicateTwoNegativeNumber()
        {
            int result;
            result = c.mul(-10, -5);
            Assert.AreEqual(50m, result, "Multiplication of two neagtive number failed");
        }

        [TestMethod]
        public void MultiplicateOneNumberOneCharacter()
        {
            int result;
            result = c.mul('a', 5);
            Assert.AreEqual(485m, result, "Multiplication of one Number and one character failed");
        }
    }
}
