using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatChallenges
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

            string[] reverseSentence = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = reverseSentence.Length - 1; i >= 0; i--)
            {
                Console.Write($"{reverseSentence[i]} ");
            }
        }

        public static void GeneratingAMultiplicationTable() 
        {
            Console.WriteLine("Let's generate a multiplication table. Enter a number: ");

            int number = int.Parse(Console.ReadLine());

            int[] numTable = new int[number];

            // This loop will start the column like so: 
            // 1 
            // 2
            // 3 
            // etc.
            for (int i = 1; i <= number; i++)
            {
                // This loop will fill in the rest of the current column like so: 
                // This example number will be 3
                // 1 X X X
                // 2 X X X 
                // 3 X X X
                // Target number with 4 
                // 1 X X X X
                // 2 X X X X
                // 3 X X X X
                // 4 X X X X
                for (int j = 1; j <= number; j++) 
                {
                    Console.WriteLine($"{i} x {j} = {j * i}\t");
                }

                Console.WriteLine();
            }
        }

        public static void FindingAllPairsThatAddToATarget()
        {
            Console.Write("Enter a list of numbers, max 5, and then a target number.\nThen we'll find pairs in the list that equal to that target number.\n");

            int[] numList = new int[5];

            Console.WriteLine("Let's enter the target number first: ");
            int targetNum = int.Parse(Console.ReadLine());

            string pairsToEqualTarget = "";

            Console.WriteLine("Now let's enter the numbers for the list: ");
            for (int i = 0; i < numList.Length; i++) 
            {
                Console.WriteLine($"Number {i + 1}:");
                numList[i] = int.Parse(Console.ReadLine());

                for (int j = 0; j <  numList.Length;  j++)
                {
                    // The additional statement after && is to ensure
                    // only one pair is added once
                    if ((numList[i] + numList[j]) == targetNum && i < j)
                    {
                        pairsToEqualTarget += $"({numList[j]},{numList[i]}) ";
                    }
                }
            }

            if (string.IsNullOrEmpty(pairsToEqualTarget))
            {
                Console.WriteLine("Doesn't look there were any numbers that matched the target number.");
            } else
            {
                Console.WriteLine($"Here are the pairs that equal the target number: {pairsToEqualTarget}");
            }
        }
    }
}
