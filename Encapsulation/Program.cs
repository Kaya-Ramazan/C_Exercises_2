using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // geter seter methods

            student std1 = new student();

            std1.setName("Kimmo");
            string newName = std1.getName();

            Console.WriteLine(newName);


            
      
           
            Console.ReadLine();



        }
    }
}
