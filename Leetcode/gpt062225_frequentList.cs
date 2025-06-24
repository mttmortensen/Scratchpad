using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class gpt062225_frequentList
    {
        public static Dictionary<char, int> MostFrequetCharacterListed(string str) 
        {
            char[] chars = str.ToCharArray();
            int currentCount = 0;
            int maxCount = 0;
            Dictionary<char, int> charCounting = new Dictionary<char, int>();

            foreach (char c in chars)
            {
                if (charCounting.ContainsKey(c)) 
                {
                    charCounting[c]++;
                    currentCount = charCounting[c];
                }
                else 
                {
                    charCounting.Add(c, 1);
                }


                if (currentCount > maxCount) 
                {
                    maxCount = currentCount;
                }
            }

            char highestLetter = charCounting.MaxBy(kvp => kvp.Value).Key;
            int higestLetterValue = charCounting.MaxBy(kvp => kvp.Value).Value;
            Dictionary<char, int> highestPair = new Dictionary<char, int>
            {
                { highestLetter, higestLetterValue }
            };

            return highestPair;
        }
    }
}
