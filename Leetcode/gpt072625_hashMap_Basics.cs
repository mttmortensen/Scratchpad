using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class gpt072625_hashMap_Basics
    {
        public static void Run() 
        {
            // 1. Create a Dictionary
            Dictionary<string, int> scores = new Dictionary<string, int>();

            // 2. Add Values
                // We are declaring the 'Alice' Key and assigning it the value of 95 in the same line
            scores["Alice"] = 95;
            scores["Bob"] = 87;

            // 3. Update Values
            scores["Alice"] = 99;

            // 4. Check if Key exists
            if (scores.ContainsKey("Bob"))
                Console.WriteLine($"Bob's score {scores["Bob"]}");

            // 5. Iterate over dictionary 
            foreach(var kvp in scores)
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}
