using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatChallenges
{
    public static class gptLISTS_052925
    {

        // This function is for gathering inputs with some error handling
        // It will call the logic function below which is set to private
        public static void GatherListInputsAndReturnEvens() 
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
            List<int> evens = OnlyReturningEvenNumbers(listOfNumbers);

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
        }

        private static List<int> OnlyReturningEvenNumbers(List<int> listOfNumbers)         
        {
            List<int> newEvenList = new List<int>();

            foreach (int num in listOfNumbers) 
            {
                if (num % 2 == 0) 
                {
                    newEvenList.Add(num);
                }
            }

            return newEvenList;
        }
    }
}
