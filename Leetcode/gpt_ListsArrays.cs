using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class gpt_ListsArrays
    {
        public string TakeAListAndReverseItToAString(List<int> listOfInts) 
        {
            // Need to covert the list of ints to list of strings first
            List<string> listOfStrings = new List<string>();

            foreach (int number in listOfInts) 
            {
                listOfStrings.Add(number.ToString());
            }

            // Somehow then reverse the list of strings 
            listOfStrings.Reverse();

            // And then turn it into a single string
            String singleString = string.Join(", ", listOfStrings);

            return singleString;
        }
    }
}
