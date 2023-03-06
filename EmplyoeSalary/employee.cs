using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyoeSalary
{
    class employee
    {
        private string name;
        private int employeeID;
        private double monthlySalary;

        public employee(string empName, int empID, double salary)
        {
            name = empName;
            employeeID = empID;
            monthlySalary = salary;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string empName)
        {
            name = empName;
        }

        public int GetEmployeeID()
        {
            return employeeID;
        }

        public void SetEmployeeID(int empID)
        {
            employeeID = empID;
        }

        public double GetMonthlySalary()
        {
            return monthlySalary;
        }

        public void SetMonthlySalary(double salary)
        {
            monthlySalary = salary;
        }

        public double YearlySalary()
        {
            return monthlySalary * 12;
        }
    }
}
