using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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

            char[] chars = { 'K', 'u', 'l', 't', 't', 'a' };

            for (int i = 0; chars.Length>i; i++) 
            {
                Console.Write(chars[i]);
            }


            Console.ReadLine();
        
        }

    }
}
