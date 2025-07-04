﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatChallenges
{
    internal class gptDSA_112224
    {
        public static void GivingTheSumOfANumber()
        {
            Console.WriteLine("Enter a number to get the sum of every number up to it: ");

            int number = int.Parse(Console.ReadLine());

            int total = number;

            for (int i = number -1; i > 0; i--)
            {
                total += i;
            }

            Console.WriteLine($"The total is {total}");

        }

        public static void PrintingARangeOfNumbers()
        {
            Console.WriteLine("Enter a starting number and an ending number to get the range between them:");

            Console.WriteLine("Starting Number");
            int startNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Ending Number");
            int endNumber = int.Parse(Console.ReadLine());

            Console.Write($"Starting from {startNumber}, ");

            for( int i = startNumber + 1; i < endNumber; i++)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine($"{endNumber}.");
            Console.WriteLine("The range is now over!");
        }

        public static void GoodOlFactorial()
        {
            Console.WriteLine("Let's do a factorial, enter a number to begin: ");

            int number = int.Parse(Console.ReadLine());

            int total = number;

            for (int i = number -1; i > 0; i--)
            {
                total *= i;
            }

            Console.WriteLine($"The factorial for your number is {total}");
        }

        public static void FindingTheSmallestNumber()
        {
            Console.WriteLine("Enter 5 random numbers, and I'll tell you the smallest one:");

            int[] numbers = new int[5];
            int smallestNumber = int.MaxValue;

            for (int i = 0;  i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

                if (numbers[i] < smallestNumber )
                {
                    smallestNumber = numbers[i];
                }
            }
            Console.WriteLine($"The smallest number out of your list is {smallestNumber}");
        }
        
        public static void HowManyTimesDoesTheLetterAppear()
        {
            Console.WriteLine("Let's see how many times a letter comes up.");
            Console.WriteLine("Enter a letter as reference (EX: 'c'):");

            char referenceLetter = char.Parse(Console.ReadLine().ToLower());

            Console.WriteLine("Enter the word to search against (EX: 'cat')");

            string word = Console.ReadLine();

            int letterCount = 0;

            for(int i = 0; i < word.Length; i++) 
            {
                if (word[i] == referenceLetter)
                {
                    letterCount++;
                }
            }

            Console.WriteLine($"The letter {referenceLetter.ToString().ToUpper()} appears in the word, {word}, {letterCount} amount of times.");

        }

        public static void CountdownFrom10()
        {
            Console.WriteLine("Let's countdown from....");

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1500);
            }

            Console.WriteLine(":) Press a key to exit...");
        }

        public static void PrintingOutEveryOtherNumber()
        {
            Console.WriteLine("Enter a number and I'll print out every other number leading up to it: "); 

            int numberToCountTo = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberToCountTo; i += 2)
            {
                Console.WriteLine(i);
                
            }
            // This will handle the last number being even but it's messes up the last two numbers
            // Not sure if I should then decide to start from 1 or 2 based on this numberToCountTo
            if (numberToCountTo % 2 == 0)
            {
                Console.WriteLine(numberToCountTo);
            }
        }

        public static void ReverseTheListOfNumbers()
        {
            Console.WriteLine("Enter 5 numbers and I'll print them in reverse order");

            int[] fiveNumbersToReverse = new int[5];

            for (int i = 0; i < fiveNumbersToReverse.Length; i++)
            {
                Console.WriteLine($"Enter Number {i + 1}");
                fiveNumbersToReverse[i] = int.Parse(Console.ReadLine());

            }

            for (int i = fiveNumbersToReverse.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"Here are the numbers reversed: {fiveNumbersToReverse[i]}");
            }
        }
        

    }
}
