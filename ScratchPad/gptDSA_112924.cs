using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad
{
    internal class gptDSA_112924
    {
        // This is more dealing with Lists that DSAs
        public static void BuildingAListOfUsernames()
        {
            Console.WriteLine("Enter 5 names, and I'll print them out.");

            List<string> usernames = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Name {i + 1}:");

                // Have to start using Add() with List<>
                usernames.Add(Console.ReadLine());
            }

            Console.WriteLine($"Here you go!:");

            for (int i = 0; i < usernames.Count; i++) 
            {
                
                Console.Write($"{usernames[i]}, ");
            }
        }

        public static void FindingTheLongestUsername()
        {
            Console.WriteLine("Enter 5 names and I'll tell you which one is the longest!");

            List<string> usernames = new List<string>();

            string longestName = "";

            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine($"Name {i + 1}");
                usernames.Add(Console.ReadLine());

                if (usernames[i].Length > longestName.Length)
                {
                    longestName = usernames[i];
                }
            }

            Console.WriteLine($"Longest Name is {longestName}");
        }

        public static void SumOfNumbers() 
        {
            Console.WriteLine("Enter 5 numbers and I'll tell you sum of them all.");

            List<int> numbers = new List<int>();

            int total = 0;

            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine($"Number {i + 1}:");
                numbers.Add(Convert.ToInt32(Console.ReadLine()));
                total += numbers[i];
            }

            Console.WriteLine($"The sum of those 5 numbers is {total}");
        }
    }
}
