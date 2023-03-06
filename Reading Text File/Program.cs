using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Reading_Text_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string PathFile = @"C:\Users\s2200072\Desktop\sample3.txt";
            string[] newfile = File.ReadAllLines(PathFile);

            foreach (string name in names) 
            {
                Console.WriteLine();
            }
            
            Console.ReadKey();

        }
    }
}
