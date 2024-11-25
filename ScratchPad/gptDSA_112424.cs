using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad
{
    public class gptDSA_112424
    {
        public static void PrintANumberTriangle()
        {
            Console.WriteLine("Enter a number and let's make a triangle out of it!");

            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++) 
            {
                // Nested loops will execute fully, meaning all iterations will be done first
                // before returning to the outter loop
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }

                // This will be our way to move onto the next line without disrupting the inner loop
                Console.WriteLine();
            }
        }
    }
}
