namespace Leetcode
{
    public class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            Dictionary<char, int> results = gpt062225_frequentList.MostFrequetCharacterListed(str);

            foreach(KeyValuePair<char,int> item in results) 
            {
                Console.WriteLine($"Highest letter was {item.Key} at {item.Value} ");
            }


            Console.ReadKey();
        }
    }
}
