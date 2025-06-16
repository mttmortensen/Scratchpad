using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class gpt061525_DuplicateList
    {
        public static List<int> RemoveDuplicates(List<int> originalList) 
        {
            List<int> newList = new List<int>();

           foreach(int item in originalList) 
            {
                if (!newList.Contains(item)) 
                {
                    newList.Add(item);
                }
            }

            return newList;
        }
    }
}
