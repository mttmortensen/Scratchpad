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
            char mostFrequest = '\0';
            int maxCount = 0;
            Dictionary<char, int> charCounting = new Dictionary<char, int>();

            foreach (char c in str.ToLower()) 
            {
                if (!char.IsLetterOrDigit(c))
                    continue;

                if (!charCounting.ContainsKey(c))
                    charCounting[c] = 0;

                // Increment the frequency 
                charCounting[c]++;

                // Immediately check if this is now the new max
                if (charCounting[c] > maxCount)
                {
                    maxCount = charCounting[c];
                    mostFrequest = c;
                }
            }

            return new Dictionary<char, int> { { mostFrequest, maxCount } };
        }
    }
}
