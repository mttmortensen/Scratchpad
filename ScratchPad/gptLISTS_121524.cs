using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatChallenges
{
    internal class gptLISTS_121524
    {
        public static void FilterEvenNumbers()
        {
            List<int> listOfNumbers = new List<int>();

            List<int> evenNumbers = new List<int>();

            Console.WriteLine("Enter 5 numbers and I'll tell you the even ones.");

            // I do have to hard code this condition so that this will run
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Number: {i + 1}");

                // Chat suggested this block instead of using [i] 

                int number = Convert.ToInt32(Console.ReadLine());

                listOfNumbers.Add(number);

                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }

            // Using string.Join() will replace the for loop
            // And now will be able to use a condition
            // to test if there are even numbers in the evenNumbers list
            if (listOfNumbers.Count > 0)
            {

                Console.WriteLine("The even numbers in your list are: ");
                Console.WriteLine(string.Join(",", evenNumbers));
            }
            else
            {
                Console.WriteLine("Doesn't look like you entered any even numbers!");
            }
        }

        public static void CountOccurrencesOfWord()
        {

            List<string> listOfWords = new List<string>();

            int targetWordCount = 0;

            Console.WriteLine("Enter a list of words, set by a maximum number, and a target word, and I'll tell you how many times it appears in the list");

            Console.WriteLine("Set the maximum amount of words in the list:");
            int maxNumberOfWords = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Now let's do the target word:");
            string targetWord = Console.ReadLine();

            Console.WriteLine("Now let's create the list: ");
            for (int i = 0; i < maxNumberOfWords; i++)
            {
                Console.WriteLine($"Word {i + 1}:");
                string word = Console.ReadLine();

                listOfWords.Add(word);
            }

            foreach (string word in listOfWords)
            {
                if (word == targetWord)
                {
                    targetWordCount++;
                }
            }

            if (targetWordCount > 0)
            {
                Console.WriteLine($"The {targetWord} appeared {targetWordCount} times");

            }
            else
            {
                Console.WriteLine($"Doesn't look like the word, {targetWord} was in the list!");
            }
        }
    }
}
