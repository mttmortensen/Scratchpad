using ChatChallenges;

internal class Program
{
    private static void Main(string[] args)
    {
        List<string> strings = new List<string> { "dog", "cat", "bird" };

        IEnumerable<string> results = gptLINQ_062625.CapitalizeAllStrings(strings);

        foreach (string str in results) 
        {
            Console.WriteLine(str);
        }

        Console.ReadLine();
    }
}