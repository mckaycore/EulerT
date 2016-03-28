using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerT
{
    public class Utility
    {
        //This function is designed to find
        //the sum of all the multiples of 3 or 5 below 1000
        //and return the answer.
        public static int GetSumOfMultiples()
        {
            int res = 0; //setup result var
            int res3 = 0; //multiples of 3 result
            int res5 = 0; //multiples of 5 result
            int res15 = 0; //multiples of 15 result

            //trap any unexpected errors
            try
            {
                //get multiples of 3 for 1000
                res3 = getmultiplesof(3, 1000);
                //get multiples of 5 for 1000
                res5 = getmultiplesof(5, 1000);
                //get multipes of 15 for 1000
                res15 = getmultiplesof(15, 1000);


                //combine multiples of 3 and 5, and subtract multiples of 15
                //because these are duplicate multiples
                res = (res3 + res5) - res15;

                //return result
                return res;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public static int getmultiplesof(int dby, int howmany)
        {
            int res = 0; //setup return var

            //trap any unexpected errors
            try
            {

                //loop through 1000 and find the multiples of dby
                for (int i = 1; i < howmany; i++)
            {
                //determine remainder, if none, then it is a multiple
                if (i % dby == 0)
                {
                    //add multiple to resule
                    res += i;
                }
            }

            }
            catch (Exception ex)
            {

                throw ex;
            }

            //return final result
            return res;
        }
    }
}
