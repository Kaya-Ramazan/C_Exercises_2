using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Exercises_2
{
    internal class Methods
    {
        /*
        static void Main(string[] args)
        {
            // parametresiz   --Geriye Döndurmeyen Metot Tanimlama.... 

            Selam();
            Selam();
            Selam();
            Selam();
            Selam();
            Selam();

            Salah();
            Salah();
        }
        /*
        static void Selam()
        {
            Console.WriteLine("Hei, Moi Kaikille :)");
            // if there is alot of cods here

        }

        static void Salah()
        {

            Console.WriteLine("Rauhallisesti akia :)) ");
            Console.ReadLine();


        }
        */

        /*
        static void Main(string[] args) 
        {
            // SumNumbers(15, 25, 35);
            //SumNumbers(100, 25, 55);

            // MultipleNumber(10, 20, 30);

            NameSurname("Ramazan", " Kaya");

            Console.ReadLine();
        
        }

        static void NameSurname(string name, string surname)
        {
            Console.WriteLine("Your name is : " + name + surname);

        }

        // parametre Alan  - Geriye Deger Döndurmeyen metod yazma 

        static void SumNumbers(int num1, int num2, int num3) 
        {
            Console.WriteLine("Sum of the numbers: " + (num1 + num2 + num3));
                
        }

        static void MultipleNumber(int num1, int num2, int num3) 
        {
            Console.WriteLine("The multiplications of number is : " + (num1*num2*num3));
        }


       */




        static void Main(string[] args) 
        {
            // Parametre alan - Geriye Dger döndurn Metot Tanimlama.
            // return anahtar kelimesi
            // metod sonu.

            //int NewValue = SumNum(15, 25);

            string UserNAmeSurname = NameSurname("Kimmo", "Niskainen");
            string UserNameSurname = NameSurname("Ramazan", "Kaya");

            Console.WriteLine(UserNAmeSurname);
            Console.WriteLine(UserNameSurname);


            Console.ReadLine();

        }
        
                   
        
       
        static int SumNum(int num1, int num2) 
        {
            int result = num1 + num2;

            return result;
        }

        static string NameSurname(string Name, string Surname) 
        {
            return Name + " " + Surname;
        }




    }
}
