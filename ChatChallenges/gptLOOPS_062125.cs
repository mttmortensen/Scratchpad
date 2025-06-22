using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatChallenges
{
    public class gptLOOPS_062125
    {
        public static void AskUntilEven()
        {
            Console.Write("Enter a number:");
            int input = int.Parse(Console.ReadLine());

            while (input % 2 != 0) 
            {
                Console.Write("Enter a number:");
                input = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Even number entered. Loop stopped.");
        }
    }
}
