using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class gpt060225_OddList
    {
        public static List<int> RemoveAllOddNumbersFromAList(List<int> targetListOfNums) 
        {
            List<int> evensOnly = new List<int>();

            foreach (int num in targetListOfNums) 
            {
                if (num % 2 == 0) 
                {
                    evensOnly.Add(num);
                }
            }

            return evensOnly;
        }
    }
}
