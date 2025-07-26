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
    }
}
