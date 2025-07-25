﻿using LINQChallenges.Models;

namespace LINQChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PersonV2> people = new List<PersonV2>();

            PersonV2 person1 = new PersonV2();
            person1.FirstName = "matt";
            person1.LastName = "mortensen";
            person1.Age = 33;
            people.Add(person1);

            PersonV2 person2 = new PersonV2();
            person2.FirstName = "sam";
            person2.LastName = "mortensen";
            person2.Age = 1;
            people.Add(person2);

            PersonV2 person3 = new PersonV2();
            person3.FirstName = "ry";
            person3.LastName = "mortensen";
            person3.Age = 30;
            people.Add(person3);

            IEnumerable<string> results = gptLINQSelectV2_072525.PeopleAndTheirAges(people);
            Console.WriteLine("People and their ages: ");
            foreach(string person in results) 
            {
                Console.WriteLine($"{person}");
            }

            Console.ReadLine();

        }
    }
}
