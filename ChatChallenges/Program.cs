using ChatChallenges;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> nums = new List<int>() { 1, 4, 3, 5, 28, 222, 2431 };

        IEnumerable<int> results = gptLINQ_062625.GetTop3LargestNumbers(nums);
        foreach (int num in results) 
        {
            Console.WriteLine(num);
        }

        Console.ReadLine();
    }
}