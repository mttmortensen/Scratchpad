using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatChallenges
{
    public class gptLINQ_062625
    {
        public static IEnumerable<int> FindAllEvenNumbers(List<int> numbers) 
        {
            return numbers.Where(n => n % 2 == 0);
        }

        public static IEnumerable<string> CapitalizeAllStrings(List<string> strings) 
        {
            return strings.Select(s => s[0].ToString().ToUpper() + s.Substring(1));
        }

        public static IEnumerable<int> GetTop3LargestNumbers(List<int> nums) 
        {
            return nums.OrderBy(n => n).Reverse().Take(3);
        }
    }
}
