using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class gpt060525_MergeList
    {
        public static List<int> MergeTwoListsIntoOneList(List<int> listOne, List<int> listTwo) 
        {
            List<int> combinedList = new List<int>();

            foreach (int numOne in listOne) 
            {
                combinedList.Add(numOne);
            }

            foreach (int numTwo in listTwo)
            {
                combinedList.Add(numTwo);
            }

            return combinedList;
        }
    }
}
