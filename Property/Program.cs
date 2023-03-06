using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Property

            /*

            Customer cstmr1 = new Customer();

            cstmr1.Id = 1001; // if we define anything else here. setter block start
            // If we don t  define anything else getter working 

            Console.WriteLine(cstmr1.Id);
            Console.ReadLine();
            */

            Customer Cstrmr1 = new Customer();
            Cstrmr1.ID = 85;
            Cstrmr1.ID2 = 85;

            Console.WriteLine("Property Customer ID : " + Cstrmr1.ID);
            Console.WriteLine("Variable Customer ID : " + Cstrmr1.ID2 );
            Console.ReadLine();




        }
    }
}
