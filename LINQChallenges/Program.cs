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

            IEnumerable<string> results = gptLINK7_072525.GetPeopleOver18(people);
            Console.WriteLine("People over 18: ");
            foreach(string person in results) 
            {
                Console.WriteLine($"{person} is over 18");
            }

            Console.ReadLine();

        }
    }
}
