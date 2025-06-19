namespace Leetcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "A man, a plan, a canal: Panama";

            bool result = gpt061925_palindromeList.IsPalindrome(input);

            Console.WriteLine($"Is your string a Palindrome?");
            Console.WriteLine($"Answer: {result}");
            Console.ReadKey();
        }
    }
}
