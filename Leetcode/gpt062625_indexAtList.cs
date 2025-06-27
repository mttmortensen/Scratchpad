using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class gpt062625_indexAtList
    {
        public static List<int> SmallerNumbersThanCurrent(List<int> nums) 
        {
            List<int> countingValuesOfOriginalList = new List<int>();

            for (int i = 0; i < nums.Count; i++) 
            {
                countingValuesOfOriginalList.Add(0);

                for (int j = 0; j < nums.Count; j++)
                {
                    if (nums[i] > nums[j]) 
                    {
                        countingValuesOfOriginalList[i]++;
                    }
                }
            }
            return countingValuesOfOriginalList;
        }
    }
}
