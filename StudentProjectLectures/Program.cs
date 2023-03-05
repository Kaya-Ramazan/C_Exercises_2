using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace StudentProjectLectures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //In this project, we will make a project with the variables named student number,
            //student name, student surname, visa 1 visa 2 and final and school names,
            //access Modifiers Private.

            // We will also apply two methods, show student information and find student average.

            // There will be another method such as bring school information.

            // according to the student's choice;
            //  1 - show the student information
            //  2 - show the student average
            //  3 - learn of the student's school
            //  4 - log out

            bool Checklsit = true;
            Student student1 = new Student("Kimmo", "Makela", 75,85,80,001,"Helsinki Business Collage" );

            

            Console.WriteLine(" You are Welcome ... Could you choose your obtain please ");

            ShowTransactions();


            while (Checklsit)
            {
                
                string Choose = Console.ReadLine();

                switch (Choose) 
                {
                    case "1":

                        student1.showstudentInform();
                        break;

                    case "2":
                        double StdntGPA = student1.FindstudentGPA();
                        Console.WriteLine("Student Avarege : " + StdntGPA);
                       
                        break;


                        

                    case "3":
                        student1.StudentSchoolInform();
                        break;

                    case "4": 
                        Checklsit= false;
                        break;
                }
            }
        }
        


        static void ShowTransactions()
        {
            Console.WriteLine(" 1 - show the student information ");
            Console.WriteLine(" 2 - show the student average");
            Console.WriteLine(" 3 - Show of the student's school");
            Console.WriteLine(" 4 - log out");
            Console.ReadLine();    
        }
    }
}
