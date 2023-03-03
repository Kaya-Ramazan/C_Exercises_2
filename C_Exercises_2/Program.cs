using System;

namespace C_Exercises_2
{
    class Program
    {


        static void Main(string[] args)
        {
            /* we make this exercises for int. define value in seriess
            int[] numbr = new int[5];

            numbr[0] = 15;
            numbr[1] = 25;
            numbr[2] = 35;
            numbr[3] = 45;
            numbr[4] = 55;

            for (int i = 0; i < numbr.Length; i++) 
            {
                Console.Write(numbr[i]);char
            }

            
            Console.ReadLine(); 
            */

            /*
            string[] names = {"Akif", "Orhan", "Bengisu", "Meral", "Ramazan"};

            for (int i = 0; i<names.Length; i++)
            {
                Console.WriteLine(names[i]);

            }

            
            Console.ReadLine();
            */
            /*
            char[] chars = { 'K', 'u', 'l', 't', 't', 'a' };

            for (int i = 0; chars.Length>i; i++) 
            {
                Console.Write(chars[i]);
            }


            Console.ReadLine();
        */
            /*
            // Get the elements of the array from the user and print them to the screen

            int[] Numbers = new int[4];

            for(int i =0; i < Numbers.Length; i++) 
            {
                Console.Write("Sequence of numbers: " + (i + 0)+ "enter index value ");
                Numbers[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("***********************************");

            for (int i= 0; i < Numbers.Length; i++) 
            {
                Console.Write(Numbers[i]);
            }
            Console.ReadLine();

            */

            /*
            string[] Names = { "Ramazan ):", "Meral :)", "Bengisu --", "Akif**", "Orhan??" };

            /*for(int i = 0; i < Names.Length; i++) 
            {
                Console.WriteLine(Names[i]);
            }
            Console.ReadLine();

            */

            // Now we try to write same kode with foreach 
            /*
            foreach (string a in Names) 
            {
                Console.Write(a);
            }
            Console.Read();
            */

            /* 
            double[] os = { 1.2, 2.3, 3.4, 4.5, 5.6, };

            foreach(double d in os) 
            {
                Console.WriteLine(d);
            }
            Console.ReadLine();

            */

            // We'll write a program that checks that
            // Is the number entered by the user in the directory? ,
            // It tells us how many there are, and warns if there isn't.
            

            int[] Numbers = { 11, 21, 31, 41, 51, 61, 71, 81, 91 ,51,51};
            int amaount = 0;
            int number;

            Console.Write("Enter a number,Please : ");
            number = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < Numbers.Length; i++) 
            {
                if (number== Numbers[i]) 
                {
                    amaount++;
                }
            }
             if (amaount == 0) 
            {
                Console.WriteLine("Your number didnt´t find in array");
            
            }
            else 
            {
                Console.WriteLine("Your number's was found ...");
                Console.WriteLine("Amount: " + amaount);
            }
            Console.ReadLine();

            

            

            

        }


    }
}
