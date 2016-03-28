using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EulerT;

namespace Euler.Tests
{
    //Test verifies sum of all letters for numbers 1 to 1000
    [TestClass]
    public class GetSumLettersForNumbersTests
    {
        [TestMethod]
        public void GetSumLettersForNumbers_Test()
        {

            int res = 0; //setup result var

            //run test in Euler Utility class directly
            res = Utility.GetSumLettersForNumbers();

            //Verify result is as expected
            if (res == 21124)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }
    }
}
