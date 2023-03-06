using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProjectLectures
{
    public class Student   // we define my class
    {
        private int Id;     // after that we define my propertise inside of my class
        private string Name;
        private string Surname;
        private int midTerm1;
        private int midTerm2;
        private int final;
        private string SchoolName;


        public Student(string _Name, string _Surname, int _midTerm1, int _midTerm2, int _final, int _ID, string _SchoolName )
        {
            // now we create contribute 
            // we got a value defined above 
            
            Id = _ID;
            Name = _Name;
            Surname = _Surname;
            midTerm1= _midTerm1;
            midTerm2= _midTerm2;
            final = _final;
            SchoolName = _SchoolName;


        }

        public void showstudentInform() 
        {
            Console.WriteLine("Student Id : " + Id);
            Console.WriteLine("Student Name : " + Name);
            Console.WriteLine("Student Surname : " + Surname);
            Console.WriteLine("Student midTerm1 : " + midTerm1);
            Console.WriteLine("Student MidTerm1 : " + midTerm2);
            Console.WriteLine("Student final : " + final);
            Console.WriteLine("Student School name : " + SchoolName);
            C# Dosya Oluşturma İşlemleri, 
        }

        public double FindstudentGPA() //  we define methods about student grade avarage
        {
            // Student Grade Point Average
            double GPA = midTerm1 * 0.2 + midTerm2 *0.2 + final * 0.6 ;
            return GPA;

        }

        public void StudentSchoolInform()  // we define methods about school name
        {
            Console.WriteLine("Student School name : " + SchoolName);
        }
    }
}
