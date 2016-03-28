using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EulerT;

namespace Euler.Tests
{
    [TestClass]
    public class GetSumLettersForNumbersTests
    {
        [TestMethod]
        public void GetSumLettersForNumbers_Test()
        {

            int res = 0;
            res = Utility.GetSumLettersForNumbers();

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
