using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatChallenges
{
    internal class gptDSA_112124
    {
        public static void ReverseASentence()
        {
            Console.WriteLine("Please enter a complete sentence, include spacing: ");

            String theSentence = Console.ReadLine();

            string reversedSentence = "";
            // I need this because doing the loop below will reverse the word itself and I don't want that
            string currentWord = "";

            for (int i = theSentence.Length - 1; i >= 0; i--)
            {
                // 
                if (theSentence[i] == ' ')
                {
                    reversedSentence += ReverseString(currentWord) + ' ';
                    currentWord = "";
                }
                else
                {
                    currentWord += theSentence[i];
                }

            }

            if (currentWord != "")
            {
                reversedSentence += ReverseString(currentWord);
            }

            Console.WriteLine(reversedSentence);
        }

        private static string ReverseString(string input)
        {
            string result = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                result += input[i];
            }
            return result;
        }

        public static void CountTheVowels()
        {
            Console.WriteLine("Enter a single word please: ");

            string word = Console.ReadLine();

            char[] vowels = ['a', 'e', 'i', 'o', 'u'];

            int vowelCount = 0;

            for (int i = 0; i < word.Length;  i++)
            {
               for (int j = 0; j < vowels.Length; j++)
                {
                    if (word[i] == vowels[j])
                    {
                        vowelCount++;
                    }
                }
            }

            Console.WriteLine($"The amount of Vowels in your word are {vowelCount}");
        }

        public static void RemoveTheSpaces()
        {
            Console.WriteLine("Enter a sentence, please include the spaces: ");

            string sentence = Console.ReadLine();

            string noSpaceSentence = "";

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] != ' ')
                {
                    noSpaceSentence += sentence[i];
                }
            }

            Console.WriteLine(noSpaceSentence);
        }

        public static void FindingTheLongestWord()
        {
            Console.WriteLine("Type out a sentence for us to use:");

            string sentence = Console.ReadLine();

            string currentWord = "";
            string longestWord = "";

            for (int i = 0; i < sentence.Length;  i++)
            {
                // If the character at the time of the loop isn't a space, then add it to currentWord
                if (sentence[i] != ' ')
                {
                    currentWord += sentence[i];
                }
                // I'm trying to steer away from nested if/else code blocks. 
                // This way it's a new if statement that should be cleaer/easier to follow. 
                /*---------------------------------------------------------------------------*/
                // If it is a space, then let's switch to comparing the currentWord length vs the longestWord length
                if (sentence[i] == ' ')
                {
                   
                    if (currentWord.Length > longestWord.Length)
                    {
                        longestWord = currentWord;
                    }
                    // And now need to reset this variable to store a new current word
                    currentWord = "";
                }
            }
            // This is to handle the last word in the sentence since that word won't have a space at the end of it. 
            if (currentWord.Length > longestWord.Length)
            {
                longestWord = currentWord;
            }

            Console.WriteLine($"The longest word is: {longestWord.ToUpper()}. It has {longestWord.Length} characters.");
        }
    }
}
