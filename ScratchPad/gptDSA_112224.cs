﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad
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

        }
    }
}
