using LINQChallenges.Models;

namespace LINQChallenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            Person person1 = new Person();
            person1.Name = "matt";
            person1.Age = 33;
            people.Add(person1);

            Person person2 = new Person();
            person2.Name = "sam";
            person2.Age = 1;
            people.Add(person2);

            Person person3 = new Person();
            person3.Name = "ry";
            person3.Age = 30;
            people.Add(person3);

            IEnumerable<int> results = gptLINQSelect_072525.GettingPeoplesAge(people);
            Console.WriteLine("People's ages: ");
            foreach(int age in results) 
            {
                Console.WriteLine($"{age}");
            }

            Console.ReadLine();

        }
    }
}
