namespace Leetcode
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> listOne = new List<int> { 1, 3, 3, 4, 2, 1, 5, 2 };

            List<int> removeDuplicates = gpt061525_DuplicateList.RemoveDuplicates(listOne);

            foreach (int num in removeDuplicates)
            {
                Console.Write($"[{num} ");
            }
            

            Console.ReadKey();
        }
    }
}
