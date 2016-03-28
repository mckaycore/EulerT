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

            //Start a new task
            var runSync = Task.Factory.StartNew(new Func<Task>(async () =>
            {
                //run get sum of multiples, return result
                int call = await Task.FromResult<int>(Utility.GetSumOfMultiples());
                //print result to console
                Console.WriteLine("Find the sum of all the multiples of 3 or 5 below 1000 - ANSWER: " + call.ToString());
                //run get sum of all letters for numbers 1 to 1000
                int call2 = await Task.FromResult<int>(Utility.GetSumLettersForNumbers());
                //print result to console
                Console.WriteLine("Number of letters in 1 to 1000 - ANSWER: " + call2.ToString());

            })).Unwrap();

            //print starting notification to console
            Console.WriteLine("Task Started");
            //run tasks and wait for completion
            runSync.Wait();
            //print ending notification to console
            Console.WriteLine("Task Completed, Press Esc Key To End....");

            //wait for esc key to exit console
            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Escape))
            {
                //Waiting for user to press Esc key to exit program...
            }



        }
    }
}
