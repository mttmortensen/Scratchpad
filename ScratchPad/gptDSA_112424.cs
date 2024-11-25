using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad
{
    public class gptDSA_112424
    {
        public static void PrintANumberTriangle()
        {
            Console.WriteLine("Enter a number and let's make a triangle out of it!");

            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++) 
            {
                // Nested loops will execute fully, meaning all iterations will be done first
                // before returning to the outter loop
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }

                // This will be our way to move onto the next line without disrupting the inner loop
                Console.WriteLine();
            }
        }

        public static void FindingTheCommonInTwoArrays()
        {
            Console.WriteLine("Enter two lists. Each with 5 numbers. We'll then compare them and see what values are the same");

            int[] numList1 = new int[5];
            int[] numList2 = new int[5];

            List<int> sameNums = new List<int>();

            for (int i = 0; i < numList1.Length; i++)
            {
                for (int j = 0; j < numList2.Length; j++)
                {
                    if (numList1[i] == numList2[j])
                    {
                        sameNums.Add(numList1[i]);
                    }
                }
            }

            Console.WriteLine("Here are the numbers that are the same in both lists:");

            for (int i = 0; i <= sameNums.Count; i++) 
            {
                Console.Write($"[{sameNums[i]}]");
            }
        }
    }
}
