namespace Leetcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<int>> accounts = new List<List<int>> {
                new List<int> { 1, 2, 3, 6 },   // Total: 12
                new List<int> { 3, 4 },      // Total: 7
                new List<int> { 7, 1, 0, 5 }    // Total: 13
            };

            Console.WriteLine(gpt062225_nestedListss.MaximumWealth(accounts));

            Console.ReadKey();
        }
    }
}
