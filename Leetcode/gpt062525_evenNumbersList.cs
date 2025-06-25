using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class gpt062525_evenNumbersList
    {
        public static int FindNumberswithEvenNumbersOfDigits(List<int> values) 
        {
            int output = 0;
            foreach (int num in values) 
            {
                if (num.ToString().Length % 2 == 0)
                    output++;
            }
            return output;
        }
    }
}
