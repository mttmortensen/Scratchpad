using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public static class gpt061925_palindromeList
    {
        public static bool IsPalindrome(string input) 
        {
            char[] brokenupString = input.ToCharArray();

            for(int i = 0; i < brokenupString.Length; i++) 
            {
                for(int j = 0; j < brokenupString.Length - 1; j++) 
                {
                    if (Char.IsLetterOrDigit(brokenupString[i]) && brokenupString[i] == brokenupString[j]) 
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
