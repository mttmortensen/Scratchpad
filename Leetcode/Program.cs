namespace Leetcode
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> values = new List<int>() 
            {
                1, 3, 2, 6, -1, 4, 1, 8, 2
            };

            int k = 5;

            List<double> results = gpt063025_slidingWindow.FindAverageSizeOfSubSizeArray(values, k);

            foreach(double num in results) 
            {
                Console.WriteLine($"{num}");
            }

            Console.ReadKey();
        }
    }
}
