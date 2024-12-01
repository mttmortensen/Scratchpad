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

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"Name {i + 1}:");
                usernames[i] = Console.ReadLine();
            }

            for (int i = 0; i <= usernames.Count; i++) 
            {
                Console.WriteLine($"Here you go!:");
                Console.Write($"{usernames[i]}, ");
            }
        }
    }
}
