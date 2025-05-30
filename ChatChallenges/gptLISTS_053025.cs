using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatChallenges
{
    public class gptLISTS_053025
    {
        public static void GettingInputAndDisplayingLargestNumber() 
        {
            Console.WriteLine("=== Enter a list of Numbers and I'll give you the largest: ===");
            string strOfNums = Console.ReadLine();
        }

        private static int FindingTheLargestNumberInAList(List<int> listOfnums)
        {
            int currentMax = 0;

            foreach (int num in listOfnums)
            {
                if (num > currentMax) 
                {
                    currentMax = num;
                }
            }

            return currentMax;
        }
    }
}
