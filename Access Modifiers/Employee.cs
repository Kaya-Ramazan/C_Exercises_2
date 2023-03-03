using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifiers
{
    public class Employee // access modifiers is public We define class name is employee
    {
        public string employeeName;   // we write my variable in side my class
        public string employeeSurname;
        public int employeeSalary;

        public string employeeGender;  // some of them heve public access modifies

        private int employeeEmployeeID; // only one of them has private access modifires
        


        public void EmployyeInformation()   // we define one public methods name is EmployeeInformation
        {
            Console.WriteLine("Employee name is   " + employeeName);
            Console.WriteLine("Employee surname is  " + employeeSurname);
            Console.WriteLine("Employee ID is " + employeeEmployeeID);
            Console.WriteLine("Employee Gender is  " + employeeGender);
            Console.WriteLine("Employee salary is  " + employeeSalary);
                
        }

        private void EmployeeNameSurname(string employeeFirstName, string employeeSurnamee) 
        {
            // we define in side of my class private methods name is EmployeeName and Surname
            Console.WriteLine("Employee name and surname is " +" " + employeeFirstName + employeeSurnamee );
                
         }



    }
}
