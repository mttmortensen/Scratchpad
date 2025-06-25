namespace Leetcode
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> values = new List<int>() 
            {
                12, 355545, 222, 26, 7896
            };

            int result = gpt062525_evenNumbersList.FindNumberswithEvenNumbersOfDigits(values);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
