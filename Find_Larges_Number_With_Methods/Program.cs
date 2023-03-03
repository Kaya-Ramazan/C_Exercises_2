using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Larges_Number_With_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //An application that finds which
            //of the two numbers we receive from the user is the largest
            //and prints the output on the screen.

            Console.Write("Enter First Number : ");
            int FirstNumber = Convert.ToInt32( Console.ReadLine());

            Console.Write("Enter second number : ");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());

            FindBiggerNumber(FirstNumber, SecondNumber);

            Console.ReadLine(); 
        }

        static void FindBiggerNumber(int number1, int number2) 
        {
            if (number1 > number2)
            {
                Console.WriteLine("First Number bigger than second number...");
            }
            else if (number1 == number2)
            {
                Console.WriteLine("Botgh of numbers is equal.");
            }
            else
            {
                Console.WriteLine("Second number is bigger than first number");
            }
        }
    }
}
