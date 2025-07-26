namespace Leetcode
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = [1, 2, 3, 1, 5];

            Dictionary<int, int> results = gpt072625_hashMap_CountOccurrences.CountOccurences(nums);

            foreach(KeyValuePair<int, int> item in results) 
            {
                Console.WriteLine($"Number: {item.Key}, Appears: {item.Value}");
            }

            Console.ReadLine();
        }
    }
}
