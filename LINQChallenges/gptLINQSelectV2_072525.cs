using LINQChallenges.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQChallenges
{
    public class gptLINQSelectV2_072525
    {
        public static IEnumerable<string> GetFullNames(IEnumerable<PersonV2> people) 
        {
            return people.Select(p => $"{p.FirstName} {p.LastName}");
        }
    }
}
