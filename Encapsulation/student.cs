using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class student
    {
        private string name;
        private int Id;
       
       public void setName(string _name)
       {
           name = _name;
           
                      
       }

        public string getName() 
        {
            return name;
          
        
        }
          
    }
}
