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


        //This function is designed to count all word letters in numbers
        //from 1 to 1000. This excludes spaces and hyphens.
        public static int GetSumLettersForNumbers()
        {
            int res = 0; //setup 100-999 result var
            int res1 = 0; //setup 1-19 result var
            int res2 = 0; //setup 20-99 result var
            //array for 1-9
            string[] onetoNineSegment = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //array for 1-19
            string[] oneToNineteenSegment = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            //arrary for tens segments
            string[] tensSegment = { "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            //array for hundreds segments
            string[] hundredsSegment = { "onehundred", "twohundred", "threehundred", "fourhundred", "fivehundred", "sixhundred", "sevenhundred", "eighthundred", "ninehundred" };



            //Get total for One to Nineteen
            for (int o = 0; o <= oneToNineteenSegment.Length - 1; o++)
            {
                //add the word length for each item 
                res1 += oneToNineteenSegment[o].Length;
            }

            //get the total letters for twenty to nintynine
            //loop through each tensSegment
            for (int t = 0; t <= tensSegment.Length - 1; t++)
            {
                //as we loop through each tensSegment, loop through one to nine for each tensSegment
                for (int s = 0; s <= onetoNineSegment.Length - 1; s++)
                {
                    //add the word length for one to nine for each segment
                    res2 += tensSegment[t].Length + onetoNineSegment[s].Length;
                }
                //add the tens segment at zero
                res2 += tensSegment[t].Length;
            }


            //get the total letters for onehundred to ninehundrednintynine
            //finally loop through the hundreds segment
            for (int h = 0; h <= hundredsSegment.Length - 1; h++)
            {
                //add the word elngth for the hundreds segment at zero
                res += hundredsSegment[h].Length;

                //for each hundreds segment, get one to nineteen
                for (int o = 0; o <= oneToNineteenSegment.Length - 1; o++)
                {
                    //add the word length including "and" for each one to nineteen to each hundreds segment
                    res += hundredsSegment[h].Length + 3 + oneToNineteenSegment[o].Length;
                }

                //loop through each tens segment for each above tens
                for (int t = 0; t <= tensSegment.Length - 1; t++)
                {
                    //loop through each one to nine segment for each hundreds/tens segment
                    for (int s = 0; s <= onetoNineSegment.Length - 1; s++)
                    {
                        //add the word length including "and" for each one to nine segment for each hundreds/tens segment
                        res += hundredsSegment[h].Length + 3 + tensSegment[t].Length + onetoNineSegment[s].Length;
                    }
                    //add the word length including "and" hundreds/tens segment at zero
                    res += hundredsSegment[h].Length + 3 + tensSegment[t].Length;
                }

            }

            //return the complete result for 1-19/20-99/100-999 + onethousand(11)
            return res + res1 + res2 + 11;

        }
    }
}
