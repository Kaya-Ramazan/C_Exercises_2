using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace file_Creations_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\demo\test.txt";

            //string[] lines= File.ReadAllLines(filePath);

            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();

            foreach (string line in lines) 
            {
                Console.WriteLine(line);
            }
            lines.Add(" Juha, Vuori, www.nobody.com ");
            File.WriteAllLines(filePath, lines);



            Console.ReadLine();
            
        }
    }
}
