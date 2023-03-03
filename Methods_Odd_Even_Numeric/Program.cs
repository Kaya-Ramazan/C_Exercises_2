using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Odd_Even_Numeric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The number that finds whether the number entered by the user is odd or even

            Console.WriteLine("Enter a number: ");
            int NumberS = int.Parse(Console.ReadLine());

            oddOrEven(NumberS);

            Console.ReadLine();

        }

        static void oddOrEven(int number) 
        {
            if (number%2 == 0) 
            {
                Console.WriteLine("Your number is even ...");
            }
            else 
            {
                Console.WriteLine(" Your number is odd...");
            }
        }

    }
}
