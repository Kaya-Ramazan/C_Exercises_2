using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmplyoeSalary
{
    public class Program
    {
        public void Main(string[] args)
        {
            employee emp = new employee("Kimmo Makela", 12345, 3000.0);
            Console.WriteLine("Employee name: {0}", emp.GetName());
            Console.WriteLine("Employee ID: {0}", emp.GetEmployeeID());
            Console.WriteLine("Monthly salary: {0:C}", emp.GetMonthlySalary());
            Console.WriteLine("Yearly salary: {0:C}", emp.YearlySalary());
            emp.SetMonthlySalary(5500.0);
            Console.WriteLine("New monthly salary: {0:C}", emp.GetMonthlySalary());
        }
    }
}
