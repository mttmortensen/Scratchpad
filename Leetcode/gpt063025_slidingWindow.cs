using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class gpt063025_slidingWindow
    {
        public List<double> FindAverageSizeOfSubSizeArray(List<int> nums, int k) 
        {
            List<double> aveList = new List<double>();
            double total = 0;

            // Setup the inital window via k
            for(int i = 0; i < k; i++) 
            {
                total += nums[i];
                aveList.Add(total / k);
            }
        }
    }
}
