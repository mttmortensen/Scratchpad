using LINQChallenges.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQChallenges
{
    public class gptLINK7_072525
    {
        public static IEnumerable<string> GetPeopleOver18(IEnumerable<Person> people) 
        {

            return people
                .Where(p => p.Age > 18)
                .Select(p => p.Name.ToUpper());
        }
    }
}
