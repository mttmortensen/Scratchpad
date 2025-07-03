using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public static class gpt063025_slidingWindow
    {
        public static List<double> FindAverageSizeOfSubSizeArray(List<int> nums, int k) 
        {
            List<double> aveList = new List<double>();
            double totalToDivide = 0;

            // Setup the inital window via k
            for(int i = 0; i < k; i++) 
            {
                totalToDivide += nums[i];
                
            }
            // This sets up the Average as I only need to do it once
            aveList.Add(totalToDivide / k);

            return aveList;
        }
    }
}
