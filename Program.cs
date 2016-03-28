using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerT
{
    class Program
    {
        static void Main(string[] args)
        {

            var runSync = Task.Factory.StartNew(new Func<Task>(async () =>
            {
                int call = await Task.FromResult<int>(Utility.GetSumOfMultiples());
                Console.WriteLine("Find the sum of all the multiples of 3 or 5 below 1000 - ANSWER: " + call.ToString());
                //int call2 = await Task.FromResult<int>(2);
                //Console.WriteLine("Number of letters in 1 to 1000 Answer: " + call2.ToString());

            })).Unwrap();

            Console.WriteLine("Task Started");
            runSync.Wait();
            Console.WriteLine("Task Completed, Press Esc Key To End....");


            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
            {
                //Waiting for user to press Esc key to exit program...
            }



        }
    }
}
