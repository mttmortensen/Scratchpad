using ChatChallenges;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers and I'll return only the even ones");
        string stringOfNumbers = Console.ReadLine();

        // I need to split up the string into a list now
        string[] stringNums = stringOfNumbers.Split();

        // The return value of listOfNumbers is an array of strings.

        // I'll get a new List ready to hold the converted nums
        List<int> listOfNumbers = new List<int>();

        // Then I'll convert it to the int type
        foreach (string strNum in stringNums)
        { 
            // The conversion
            int.TryParse(strNum, out int num);
            // Adding to the new even list
            listOfNumbers.Add(num);
        }

        // Pass it through to the function with some error handling
        // This is kinda bad practice as we should do the error hanlding in the function itself 
        // But this is just for understanding and doing it ourselves.
        List<int> evens = gptLISTS_052925.OnlyReturningEvenNumbers(listOfNumbers);

        // This is a List method to check to see if the Evens List has any elements
        if (!evens.Any())
        {
            Console.WriteLine("Doesn't look like there was any evens!");
        }
        else
        {
            Console.WriteLine("\nEven ones are: ");
            foreach (int e in evens)
            {

                Console.WriteLine($"{e}");
            }
        }

        Console.ReadLine();
    }
}