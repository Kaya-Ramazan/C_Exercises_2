using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Exercises
{
    public class Employeers
    {
        private string IdNo;

        public string IDNO 
        {
            get 
            {
                return IdNo.Substring(0,5)+ "******";
            
            }
            set 
            {
                bool checklist = false;

                if (value.Length == 11) 
                {
                    
                    for(int i=0; i<value.Length; i++) 
                    {
                        bool IsItNumber = char.IsNumber(value[i]);

                        if (IsItNumber) 
                        {
                            // we don t make need any thing else 
                        }
                        else 
                        {
                            checklist = true;
                            break;
                        }
                    }
                    if (checklist) 
                    {
                        Console.WriteLine("Your ID number contains an invalid character. ");
                    }
                    else 
                    {
                        checklist = true;
                        break;
                    
                    }
                }
                else
                {
                    Console.WriteLine("ID number must be 11 chracters...");
                }
            
            }
        }


    }
}
