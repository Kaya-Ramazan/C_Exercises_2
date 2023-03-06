using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        { // We will get the Employee ID and we want the following checks to be made.
          // 1 - Employee ID must be 11 characters
          // 2 All characters must be numeric characters
          // GET requirement:
          // I'll take the first 5 characters of the ID, not all of them.

            Employeers emp1 = new Employeers();
            emp1.IDNO = "12345678912";

            Console.WriteLine(" Your ID number is : " + emp1.IDNO);
            Console.ReadLine();

             





        }
    }
}
