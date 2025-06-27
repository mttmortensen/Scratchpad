namespace Leetcode
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> values = new List<int>() 
            {
                8, 1, 2, 2, 3
            };

            List<int> results = gpt062625_indexAtList.SmallerNumbersThanCurrent(values);

            foreach (int num in results)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}
