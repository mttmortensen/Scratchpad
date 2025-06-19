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
            int currentNumber;

            foreach(int num1 in list) 
            {
                foreach(int num2 in list) 
                {
                    if (list.IndexOf(num1) != list.IndexOf(num2) && num1 + num2 == target) 
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
