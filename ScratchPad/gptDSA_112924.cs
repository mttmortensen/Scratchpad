using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad
{
    internal class gptDSA_112924
    {
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
    }
}
