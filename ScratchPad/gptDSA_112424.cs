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

            // We can use just numList1 because both lists have the same count for the array
            for (int i = 0; i < numList1.Length; i++)
            {
                Console.WriteLine($"Number {i} for List 1");
                numList1[i] = int.Parse(Console.ReadLine());

                Console.WriteLine($"Number {i} for List 2");
                numList2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numList1.Length; i++)
            {
                for (int j = 0; j < numList2.Length; j++)
                {
                    // The second part of the condition is to make sure that 
                    // it doesn't add duplicates to sameNums if the same number appears more than once in numList1 or numList2.
                    if (numList1[i] == numList2[j] && !sameNums.Contains(numList1[i]))
                    {
                        sameNums.Add(numList1[i]);
                    }
                }
            }

            if (sameNums.Count == 0) 
            {
                Console.WriteLine("There doesn't seem to be any common numbers in this list");

            }
            else
            {
                Console.WriteLine("Here are the numbers that are the same in both lists:");

                for (int i = 0; i <= sameNums.Count - 1; i++) 
                {
                    Console.Write($"[{sameNums[i]}]");
                }
            }

            
        }

        public static void ReverseWordsInSentence()
        {
            Console.WriteLine("Enter a sentence, include spaces, and let's reverse the order!");

            string sentence = Console.ReadLine();

            string[] reverseSentence = sentence.Split(' ');

            for (int i = 0; i < sentence.Length; i++)
            {
                Console.WriteLine(reverseSentence[i]);
            }
        }
    }
}
