using CalciLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalciLibTest
{
    [TestClass]
    public class CalciTest
    {
        Calculator c = new Calculator();

        [TestMethod]
        public void checkNo2IsEven()
        {    
            bool expectedValue = true;
            int inputValue = 2;

            bool actualValue = c.CheckEven(inputValue);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void checkNo0IsEven()
        {
            bool expectedValue = true;
            int inputValue = 0;

            bool actualValue = c.CheckEven(inputValue);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void checkNoNeg1IsEven()
        {
            bool expectedValue = false;
            int inputValue = -1;

            bool actualValue = c.CheckEven(inputValue);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void checkNo1IsPrime()
        {
            bool expectedValue = false;
            int inputValue = 1;

            bool actualValue = c.CheckPrime(inputValue);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void checkNoNeg1IsPrime()
        {
            bool expectedValue = false;
            int inputValue = -1;

            bool actualValue = c.CheckPrime(inputValue);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void checkNo0IsPrime()
        {
            bool expectedValue = false;
            int inputValue = 0;

            bool actualValue = c.CheckPrime(inputValue);

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void checkNo3IsPrime()
        {
            bool expectedValue = true;
            int inputValue = 3;

            bool actualValue = c.CheckPrime(inputValue);

            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}
