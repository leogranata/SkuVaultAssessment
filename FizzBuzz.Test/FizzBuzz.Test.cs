using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Test
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void EndInputEqualsZero_ReturnEmpty()
        {
            FizzBuzz fb = new FizzBuzz(0);
            Assert.IsTrue(fb.RunFizzBuzz().Length == 0);
        }

        [TestMethod]
        public void EndInputIsNegative_ThrownException()
        {
            try
            {
                FizzBuzz fb = new FizzBuzz(-1);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(StringAssert.Equals(ex.Message, ExceptionMessages.EndMustBeGreaterThanZero));
            }
            
        }

        [TestMethod]
        public void Input5_ReturnCorrectValues()
        {
            string expectedResult = "1\r\n2\r\nFizz\r\n4\r\nBuzz\r\n";

            FizzBuzz fb = new FizzBuzz(5);
            string result = fb.RunFizzBuzz();
            Assert.IsTrue(StringAssert.Equals(result, expectedResult));
        }

    }
}
