using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class gpt072625_hashMap_CountOccurrences
    {
        public static Dictionary<int, int>CountOccurrences(List<int> nums) 
        {
            Dictionary<int, int> occurrences = new Dictionary<int, int>();

            foreach(int num in nums) 
            {
                if (occurrences.ContainsKey(num))
                    occurrences[num]++;
                else
                    occurrences[num] = 1;
            }

            return occurrences;
        }

        // Tuple is being returned () 
        // This is just a quick way of doing a key pair value without 
        // having it belong to any class/obj
        // we could totally do a Dictionary but that would return a whole 
        // object instead of just a couple of ints
        public static (int number, int frequency) MostFrequent(List<int> nums) 
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            int number = 0;
            int frequency = 0;

            foreach(int num in nums) 
            {
                if (!map.ContainsKey(num))
                    map[num] = 1;
                else
                    map[num]++;
            }

            foreach(KeyValuePair<int, int> num in map) 
            {
                if (num.Value > frequency)
                {
                    number = num.Key;
                    frequency = num.Value;
                }
            }

            return (number, frequency);
        }
    }
}
