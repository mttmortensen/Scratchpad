using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad
{
    public class gptLISTS_042325
    {
        public static void DoubleEvensRemoveOdds()
        {

            List<int> doubledEvenNumbers = new List<int>();

            Console.WriteLine("Enter 5 random numbers and I'll double the even and remove the odd ones.");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter number {i + 1}:");

                int numToCheck = Convert.ToInt32( Console.ReadLine() );

                if (numToCheck % 2 == 0)
                {
                    doubledEvenNumbers.Add(numToCheck * 2);
                }
            }

            if (doubledEvenNumbers.Count == 0)
            {
                Console.WriteLine("There seem to be no even numbers!");
            } else 
            {
                Console.WriteLine("Here are your even numbers!:");
                Console.WriteLine(String.Join(",", doubledEvenNumbers));
            }
        }

        // 4.24.25
        public static void CountTheOccurrences() 
        {
            List<string> listOfWords = new List<string>();

            Dictionary<string, int> occurancePairs = new Dictionary<string, int>();

            Console.WriteLine("Enter a list of words (max 6), and I'll tell you how many times a word appears:");

            for (int i = 0; i < 5; i++) 
            {
                string inputWord = Console.ReadLine();

                listOfWords.Add(inputWord);
                
            }
            
            foreach (string word in listOfWords)
            {
                if (occurancePairs.ContainsKey(word))
                {
                    occurancePairs[word]++;
                } 
                else
                {
                    occurancePairs.Add(word, 1);
                }
            }

            foreach (var occurance in occurancePairs) 
            {
                Console.WriteLine($"{occurance.Key}:{occurance.Value}");
            }
            
        }

        public static void OnlyShortNamesAllowed() 
        {
            Console.WriteLine("Enter a list of names (max 5) and I'll sort them and remove any that are 4 characters or more!");

            string inputOfNames = Console.ReadLine();

            List<string> listOfnames = new List<string>();

            string[] names = inputOfNames.Split(" ");

            foreach (string name in names) 
            {
                if (name.Length <= 4)
                {
                   listOfnames.Add(name);
                }
            }

            Console.WriteLine("Here's your list!");
            listOfnames.Sort();
            foreach (string name in listOfnames)
            {
                Console.WriteLine(name);
            }
        }

        // 4.25.25
        public static void HowPopularIsEachWord() 
        {
            Console.WriteLine("Enter a list of words (return to finish) and I'll tell you how many times each word appears and remove the ones that appear once!");
            
            string inputOfWords = Console.ReadLine();

            List<string> listOfWords = inputOfWords.Split(" ").ToList();

            Dictionary<string, int> countOfWords = new Dictionary<string, int>();

            foreach (string word in listOfWords) 
            {
                if (!countOfWords.ContainsKey(word))
                {
                    countOfWords.Add(word, 1);
                }
                else 
                {
                    countOfWords[word]++;
                }
            }

            // This List KVP is so I can have multiple of the same values added 
            List<KeyValuePair<string, int>> wordsWithMoreThanOne = new List<KeyValuePair<string, int>>();

            foreach (var word in countOfWords) 
            {
               if (word.Value > 1) 
                {
                    wordsWithMoreThanOne.Add(word);
                }
            }

            wordsWithMoreThanOne.Sort((a, b) => b.Value.CompareTo(a.Value));

            foreach (var words in wordsWithMoreThanOne) 
            {
                Console.WriteLine($"{words.Key}: {words.Value}");
            }
        }

        public static void GroceryInventoryManager() 
        {
            List<KeyValuePair<string, int>> groceryList = new List<KeyValuePair<string, int>>();

            string groceryItem = "";
            int groceryItemCount = 0;

            // Writing out the list and it's quantity
            // Storing it to groceryList
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine($"Enter Item {i + 1}:");
                groceryItem = Console.ReadLine();

                Console.WriteLine("Enter Quanity:");
                groceryItemCount = Convert.ToInt32(Console.ReadLine());

                groceryList.Add(new KeyValuePair<string, int>(groceryItem, groceryItemCount));
            }

            // Output to console
            foreach (var item in groceryList) 
            {
                Console.WriteLine($"ITEM: {item.Key}: QTY: {item.Value}");
            }
        }
    }
}
