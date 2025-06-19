namespace Leetcode
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> list = new List<int> { 2, 7, 11, 15 };
            int target = 18;

            bool targetMet = gpt061625_TwoSum.TwoSum(list, target);

            Console.WriteLine($"The list you entered was: {list}");
            Console.WriteLine($"The target was: {target}");
            Console.WriteLine($"Do any of those numbers in the list add up to the target?");
            Console.WriteLine($"Answer: {targetMet}");
            

            Console.ReadKey();
        }
    }
}
