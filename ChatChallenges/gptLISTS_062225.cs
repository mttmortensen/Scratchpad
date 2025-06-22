using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatChallenges
{
    public class gptLISTS_062225
    {
        public static void ListInputForCounting() 
        {
            List<int> nums = new List<int> { 2, 3, 5, 3, 3, 7, 8 };
            int target = 3;
            CountTargetOccurrences(nums, target);
            
        }
        private static int CountTargetOccurrences(List<int> nums, int target) 
        {
            int counter = 0; 

            if (target == 0) 
            {
                Console.WriteLine("You didn't enter a target number to check against");
                return counter;
            }

            foreach(int num in nums) 
            {
                if(num == target) 
                {
                    counter++;
                }
            }

            Console.WriteLine($"In your list, your target number, {target}, comes up {counter} times.");
            return counter;
        }
    }
}
