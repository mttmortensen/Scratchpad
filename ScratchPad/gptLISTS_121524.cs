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

            for (int i = 0; i < listOfNumbers.Count; i++) 
            {
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

                // Handling last entry
                if (evenNumbers.Count - 1 == -1 )
                {
                    Console.Write($"{i}");
                }
            }
        }
    }
}
