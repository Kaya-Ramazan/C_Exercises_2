using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            
            // ex - 1 
            // this code include that; we will take the square of the number we received from the user
            // and if it is greater than 25;
            // Application that prints "square is less than 25" unless "square is greater than 25"


            Console.Write("Enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());

            int ResultSquare = SquareMeth(number);

            if (ResultSquare > 25)
            {
                Console.WriteLine("Result is bigger than 25");
            }
            else
            {
                Console.WriteLine("Result is less than 25 ");
            }
            Console.ReadLine();


        }
        static int SquareMeth(int n) 
        {
            return n * n;
        }
        
        
    }
}
