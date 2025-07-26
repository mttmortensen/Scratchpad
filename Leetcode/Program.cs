namespace Leetcode
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = [1, 2, 3, 1, 5, 5, 5];

            (int, int) results = gpt072625_hashMap_CountOccurrences.MostFrequent(nums);

            Console.WriteLine(results);

            Console.ReadLine();
        }
    }
}
