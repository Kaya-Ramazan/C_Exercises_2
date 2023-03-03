using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Autoa
    {

        public int doorAmount;
        public string CarModel;

        public string CarColour;


        public void startEngine() 
        {
            Console.WriteLine("The cars engine is starting...");
        }
        public void stopEngine() 
        {
            Console.WriteLine("The cars engine is stopping");
        }

        public void doorLocking() 
        {
            Console.WriteLine("The cars door is locking");
        }

        public void doorOpening() 
        {
            Console.WriteLine("The cars door is openining");
        }


    }
}
