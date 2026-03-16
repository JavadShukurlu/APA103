using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace _03_ObjectClassConstructorInheritanceThisvsBase.Models
{
    internal class Student:Person
    {
        public string StudentNumber { get; set; }
        public string Faculty { get; set; }
        public double GPA { get; set; }
        public int Year { get; set; }

        public Student()
        {
            
        }
        public Student(string studentnumber):this()
        {
            StudentNumber = studentnumber;
        }
        public Student(string studentnumber,string faculty):this(studentnumber)
        {
            Faculty = faculty;
        }
        public Student(string studentnumber,string faculty,double gpa):this(studentnumber,faculty)
        {
            GPA = gpa;
        }
        public Student(string studentnumber, string faculty, double gpa,int year):this(studentnumber,faculty,gpa)
        {
            Year = year;
        }
        public Student(string id, string firstname, string lastname, int age, string email):base(id,firstname,lastname,age,email)
        {
            
        }

        public void ShowStudentInfo()
        {
            Console.WriteLine($"StudentNumber:{StudentNumber},Faculty:{Faculty},GPA:{GPA},Year:{Year}");
        }

        public int CalculateScholarship()
        {
            if(GPA>=90)
                return 500;
            else if(GPA>=80)
                return 350;
            else if (GPA >= 70)
                return 200;
            else
                return 0;
        }
    }
}
