using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad
{
    internal class gptLISTS_121524
    {
        public static void FilterEvenNumbers()
        {
            List<int> listOfNumbers = new List<int>();

            List<int> evenNumbers = new List<int>();

            Console.WriteLine("Enter 5 numbers and I'll tell you the even ones.");

            // I do have to hard code this condition so that this will run
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine($"Number: {i + 1}");

                listOfNumbers.Add(Convert.ToInt32(Console.ReadLine()));

                if (listOfNumbers[i] % 2 == 0)
                {
                    evenNumbers.Add(listOfNumbers[i]);
                }
            }

            Console.WriteLine("The even numbers in your list are: ");
            foreach (int i in evenNumbers) 
            {
                Console.Write($"{i}, ");

                // Way to handle the last entry w/o a comma
                if (listOfNumbers.Count == -1)
                {
                    Console.Write($"{i}");
                }
            }
        }
    }
}
