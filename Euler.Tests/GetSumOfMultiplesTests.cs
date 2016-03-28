using Microsoft.VisualStudio.TestTools.UnitTesting;
using EulerT;

namespace Euler.Tests
{

    //Test verifies each multiples interval 3/5/15
    [TestClass]
    public class GetSumOfMultiplesTests
    {
        //Test multiples of 3 for 1000. Expect 166833.
        [TestMethod]
        public void MultiplesOf3_Test()
        {

            int res = 0;  //setup result var

            //run test in Euler Utility class directly
            res = Utility.getmultiplesof(3, 1000);

            //Verify result is as expected
            if (res == 166833)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

        //Test multiples of 5 for 1000. Expect 99500.
        [TestMethod]
        public void MultiplesOf5_Test()
        {

            int res = 0; //setup result var

            //run test in Euler Utility class directly
            res = Utility.getmultiplesof(5, 1000);

            //Verify result is as expected
            if (res == 99500)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

        //Test multiples of 15 for 1000. Expect 33165.
        [TestMethod]
        public void MultiplesOf15_Test()
        {

            int res = 0; //setup result var

            //run test in Euler Utility class directly
            res = Utility.getmultiplesof(15, 1000);

            //Verify result is as expected
            if (res == 33165)
            {
                Assert.IsTrue(true);
            }
            else
            {
                Assert.IsTrue(false);
            }
        }

        //Test multiples of 3 and 5 for 1000. Expect 233168.
        [TestMethod]
        public void ExpectedAnswerFindSumMultiples3or5Below1000_Test()
        {

            int res = 0; //setup result var

            //run test in Euler Utility class directly
            res = Utility.GetSumOfMultiples();

            //Verify result is as expected
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
