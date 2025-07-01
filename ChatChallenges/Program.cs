using ChatChallenges;

internal class Program
{
    private static void Main(string[] args)
    {
        List<int> nums = new List<int>() { 0,  10, 10 };

        IEnumerable<int> results = gptLINQ_063025.MultiplyAllNumbersByTheirIndex(nums);
        foreach (int num in results) 
        {
            Console.WriteLine(num);
        }

        Console.ReadLine();
    }
}