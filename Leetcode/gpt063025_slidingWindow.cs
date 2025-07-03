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
            double windowSum = 0;

            // Setup the inital window via k
            for(int i = 0; i < k; i++) 
            {
                windowSum += nums[i];
                
            }
            // This sets up the Average as I only need to do it once for the inital
            aveList.Add(windowSum / k);

            // Now I need to setup the sliding window
            for (int i = k; i < nums.Count; i++) 
            {
                windowSum -= nums[i - k];

                windowSum += nums[i];

                // I still want to get the rest of the averages and put them all in the list
                aveList.Add(windowSum / k);
            }

            return aveList;
        }
    }
}
