using Microsoft.VisualStudio.TestTools.UnitTesting;
using EulerT;

namespace Euler.Tests
{
    [TestClass]
    public class GetSumOfMultiplesTests
    {
        [TestMethod]
        public void MultiplesOf3_Test()
        {

            int res = 0;
            res = Utility.getmultiplesof(3, 1000);

            if (res == 166833)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void MultiplesOf5_Test()
        {

            int res = 0;
            res = Utility.getmultiplesof(5, 1000);

            if (res == 99500)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void MultiplesOf15_Test()
        {

            int res = 0;
            res = Utility.getmultiplesof(15, 1000);

            if (res == 33165)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

        [TestMethod]
        public void ExpectedAnswerFindSumMultiples3or5Below1000_Test()
        {

            int res = 0;
            res = Utility.GetSumOfMultiples();

            if (res == 233168)
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
