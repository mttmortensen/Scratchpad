using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public class gpt062125_countdownList
    {
        public static void Countdown(int start) 
        {
            while (start >= 0) 
            {
                Console.WriteLine($"{start}");
                start--;
            }
        }
    }
}
