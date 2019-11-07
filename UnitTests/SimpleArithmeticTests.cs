using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class SimpleArithmeticTests
    {
        [TestMethod]
        public void TestAddition()
        {
            var simpleArithmetic = new SimpleArithmetic();

            Assert.IsTrue(simpleArithmetic.Addition(2, 1) == 3);
        }

        [TestMethod]
        public void TestSubtraction()
        {
            var simpleArithmetic = new SimpleArithmetic();

            Assert.IsTrue(simpleArithmetic.Subtraction(5, 1) == 4);
        }

        [TestMethod]
        public void TestMultiplication()
        {
            var simpleArithmetic = new SimpleArithmetic();

            Assert.IsTrue(simpleArithmetic.Multiplication(7, 70) == 490);
        }

        [TestMethod]
        public void TestDivision()
        {
            var simpleArithmetic = new SimpleArithmetic();

            Assert.IsTrue(simpleArithmetic.Division(32, 4) == 8);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivisionByZero()
        {
            var simpleArithmetic = new SimpleArithmetic();

            simpleArithmetic.Division(2,0);
        }
    }
}