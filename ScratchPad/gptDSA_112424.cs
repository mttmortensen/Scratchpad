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
                Console.WriteLine(i + " ");
            }
        }
    }
}
