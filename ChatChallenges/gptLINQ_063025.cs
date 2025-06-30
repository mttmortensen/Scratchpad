using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatChallenges
{
    public class gptLINQ_063025
    {
        public static int CountStringsLongerThan5Characters(IEnumerable<string> words) 
        {
            return words.Count(w => w.Length > 5);
        }
    }
}
