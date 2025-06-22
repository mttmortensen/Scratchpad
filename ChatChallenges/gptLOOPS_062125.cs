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

        public static void SumUntilZero() 
        {
            int total = 0;

            Console.WriteLine("Enter numbers to get a total of it, enter 0 to exit");

            Console.WriteLine("Enter a number:");
            int num = int.Parse(Console.ReadLine());

            if (num == 0) 
            {
                Console.WriteLine("Exiting...");
            }

            while (num != 0) 
            {
                total += num;
                Console.WriteLine("Enter a number:");
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Total is: {total}");
        }

        public static void BuildListFromInput() 
        {
            Console.WriteLine("Enter words until you type 'done' and I'll build a list out of it");

            Console.Write("Enter a word:");
            string input = Console.ReadLine();

            if (input == "done") 
            {
                Console.WriteLine("You didn't enter any words, see ya");
                return;
            }

            List<string> listOfWords = new List<string>();
            
            while (input.ToLower() != "done") 
            {
                listOfWords.Add(input);
                Console.Write("Enter a word:");
                input = Console.ReadLine();
            }

            Console.WriteLine("You entered:");

            foreach (string word in listOfWords) 
            {
                Console.WriteLine($"{word}");
            }
        }
    }
}
