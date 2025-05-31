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

            List<string> strListOfNums = strOfNums.Split(" ").ToList();
            List<int> intListOfNums = new List<int>();

            foreach (string s in strListOfNums) 
            {
                intListOfNums.Add(int.Parse(s));
            }

            int largestNum = FindingTheLargestNumberInAList(intListOfNums);

            Console.Write($"The largest number out of your list was {largestNum}!");

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
