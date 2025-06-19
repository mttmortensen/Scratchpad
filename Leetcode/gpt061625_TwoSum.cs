using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class gpt061625_TwoSum
    {
        public static bool TwoSum(List<int> list, int target) 
        {
            bool isEquals = false;

            int currentNumber;

            foreach(int num in list) 
            {
                currentNumber = num; 

                if (currentNumber + num == target) 
                {
                    currentNumber = 0;
                    isEquals = true;
                    return isEquals;
                }
            }

            return isEquals;
        }
    }
}
