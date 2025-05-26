using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatChallenges
{
    public class gptDSA_112024
    {
        public static void Print10Numbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void CountdownFrom10()
        {
            for( int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void SummingFrom10()
        {
            var total = 0;

            for (int i = 0; i <= 10; i++)
            {
                total += i;
            }

            Console.WriteLine($"Total from adding 1 - 10 equals: {total}");
        } 

        public static void PrintingFromUser() 
        {
            Console.WriteLine("Please enter a number: ");
            int max_number =  int.Parse(Console.ReadLine());

            for (int i = 1; i <= max_number; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void UserMultiplicationTable()
        {
            Console.WriteLine("Please enter a number: ");
            int max_number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{max_number} * {i} = {max_number * i}");
            }
        }

        public static void FindingTheLargestNumber()
        {
            Console.WriteLine("Enter 5 random numbers: ");

            int currentLargestNumber = 0;

            for (int i = 0; i <= 4; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number > currentLargestNumber)
                {
                    currentLargestNumber = number;
                }

            }

            Console.WriteLine($"The largest number is: {currentLargestNumber}");
        }
    }
}
