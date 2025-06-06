namespace Leetcode
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> listOne = new List<int> { 1, 3, 4, 6 };
            List<int> listTwo = new List<int> { 2, 5, 7, 8 };

            List<int> mergedList = gpt060525_MergeList.MergeTwoListsIntoOneList(listOne, listTwo);

            foreach (int num in mergedList)
            {
                Console.WriteLine($"[{num} ");
            }
            

            Console.ReadKey();
        }
    }
}
