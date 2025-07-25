using LINQChallenges.Models;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQChallenges
{
    public class gptLINQSelect_072525
    {
        public static IEnumerable<int> NumbersGreaterThan10(IEnumerable<int> nums) 
        {
            return nums.Where(n => n > 10);
        }

        public static IEnumerable<string> AllNamesInUpperCase(IEnumerable<string> names) 
        {
            return names.Select(n => n.ToUpper());
        }

        public static IEnumerable<int> GettingPeoplesAge(IEnumerable<Person> people) 
        {
            return people.Select(p => p.Age);
        }

        public static IEnumerable<string> GettingAllNamesOlderThan18(IEnumerable<Person> people) 
        {
            return people
                .Where(p => p.Age > 18)
                .Select(p => p.Name);
        }

        public static IEnumerable<string> GettingAllNamesOlderThan18V2(IEnumerable<Person> people)
        {
            return people
                .Where(p => p.Age > 18)
                .Select(p => $"{p.Name} is {p.Age} years old");
        }
    }
}
