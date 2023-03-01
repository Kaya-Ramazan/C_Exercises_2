using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compares_Sum_of_Odd__and__Even__Numbers__list
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // We are coding the program that takes 10 int values from the user and makes the presentations....

            // 1 - How many odd and how many even elements
            // 2 - Sum of even values, sum of odd values
            // 3 - Finally, let him check and write that if the sum of the even values is greater than the odd values,
            // the sum of the even values is greater.
            //  If the sum of the Odds is great, write the Sum of the Odd values is great.


            int[] Numbers = new int[10];

            int oddNumbersSum = 0;
            int evenNumbersSum = 0;

            int oddNumbersAmountSum = 0;
            int evenNumbersAmountSum = 0;

            int userValue;

            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.Write((i + 0) + " .value enter please : ");
                userValue = int.Parse(Console.ReadLine());

                Numbers[i] = userValue; // I filled inside of my array with values i got from the user 
            }

            for (int j = 0; j < Numbers.Length; j++)
            {
                if (Numbers[j] % 2 == 0)
                {
                    evenNumbersSum++;
                    evenNumbersAmountSum += Numbers[j];
                }
                else
                {
                    oddNumbersSum++;
                    oddNumbersAmountSum += Numbers[j];
                }
            }

            if (oddNumbersSum > evenNumbersSum)
            {
                Console.WriteLine("Sum of the Odd Numbers is bigger than Sum of the even Numbers");

            }
            else
            {
                Console.WriteLine("Sum of the even Numbers is bigger than Sum of the odd Numbers. ");
            }

            Console.WriteLine("***************************************************");
            Console.WriteLine("Sum of the even Numbers :  " + evenNumbersSum);
            Console.WriteLine("Amaount of the even Numbers :  " + evenNumbersAmountSum);

            Console.WriteLine("***************************************************");

            Console.WriteLine("Sum of the odd Numbers : " + oddNumbersSum);
            Console.WriteLine("Amount of the odd Numbers : " + oddNumbersAmountSum);
            Console.ReadLine();



        }
    }
    }

