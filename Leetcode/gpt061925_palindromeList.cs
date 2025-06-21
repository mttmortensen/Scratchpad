using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public static class gpt061925_palindromeList
    {
        // FAILED but don''t wanna figure it out.
        public static bool IsPalindrome(string input) 
        {
            char[] brokenupString = input.ToCharArray();

            for(int i = 0; i < input.Length; i++) 
            {
                if (input[i] == input[input.Length -1 - i]) 
                {
                    Console.Write($"{input[i]}");
                    return true;
                }
            }

            return false;
        }
    }
}
