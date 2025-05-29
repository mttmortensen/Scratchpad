using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatChallenges
{
    public static class gptLISTS_052925
    {
        public static List<int> OnlyReturningEvenNumbers(List<int> listOfNumbers)         
        {
            List<int> newEvenList = new List<int>();

            foreach (int num in listOfNumbers) 
            {
                if (num % 2 == 0) 
                {
                    newEvenList.Add(num);
                }
            }

            return newEvenList;
        }
    }
}
