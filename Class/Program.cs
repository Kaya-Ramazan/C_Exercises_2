using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Autoa cars1 = new Autoa();

            cars1.doorAmount = 5;
            cars1.CarColour = "Grey";
            cars1.CarModel = "Toyota";
            


            cars1.doorLocking();
            cars1.startEngine();

            Console.WriteLine(" My Car´s has got " + cars1.doorAmount + " door");
            Console.WriteLine(" My car s colors " + cars1.CarColour);
            Console.WriteLine(" MY cars Model is " + cars1.CarModel);

            cars1.stopEngine();

            Console.WriteLine("Good luck!! Have a nice day!!!");
            Console.ReadLine();

        }
    }
}
