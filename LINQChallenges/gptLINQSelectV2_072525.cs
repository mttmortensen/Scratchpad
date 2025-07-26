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

        public static IEnumerable<string> GetTwoOldest(IEnumerable<PersonV2> people) 
        {
            return people
                .OrderByDescending(p => p.Age)
                .Take(2)
                .Select(p => $"Name: {p.FirstName} {p.LastName}, Age: {p.Age}");
        }

        public static IEnumerable<string> GroupWordsByFirstLetter(IEnumerable<string> words) 
        {
            return words
                .GroupBy(w => w[0])
                .Select(group => $"{group.Key}: {string.Join(",", group)}");
        }
    }
}
