using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad
{
    public class gptLISTS_042325
    {
        public static void DoubleEvensRemoveOdds()
        {

            List<int> doubledEvenNumbers = new List<int>();

            Console.WriteLine("Enter 5 random numbers and I'll double the even and remove the odd ones.");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter number {i + 1}:");

                int numToCheck = Convert.ToInt32( Console.ReadLine() );

                if (numToCheck % 2 == 0)
                {
                    doubledEvenNumbers.Add(numToCheck * 2);
                }
            }

            if (doubledEvenNumbers.Count == 0)
            {
                Console.WriteLine("There seem to be no even numbers!");
            } else 
            {
                Console.WriteLine("Here are your even numbers!:");
                Console.WriteLine(String.Join(",", doubledEvenNumbers));
            }
        }

        public static void CountTheOccurrences() 
        {

        }
    }
}
