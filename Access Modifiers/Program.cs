using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // public --- private 

            Employee employe1 = new Employee(); // we define new attribute 
            Employee employe2 = new Employee(); // we define new attribute 

            employe1.employeeName = "Kimmo";
            employe2.employeeName = "Ramazan";

            employe1.employeeSurname = "Lahtinen";
            employe2.employeeSurname = "Kaya";

            employe1.employeeGender = "Male";
            employe2.employeeGender = "Male";

            employe1.employeeSalary = 3500;
            employe2.employeeSalary = 2750;

            employe1.



        }
    }
}
