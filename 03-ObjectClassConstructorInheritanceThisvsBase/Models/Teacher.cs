using System;
using System.Collections.Generic;
using System.Text;

namespace _03_ObjectClassConstructorInheritanceThisvsBase.Models
{
    internal class Teacher:Person
    {
        public string Department { get; set; }
        public string MainSubject { get; set; }
        public decimal BaseSalary { get; set; }
        public int ExperienceYears { get; set; }

        public Teacher()
        {

        }
        public Teacher(string department) : this()
        {
            Department = department;
        }
        public Teacher(string department, string mainsubkect) : this(department)
        {
            MainSubject = mainsubkect;
        }
        public Teacher(string department, string mainsubkect, decimal basesalary) : this(department, mainsubkect)
        {
            BaseSalary = basesalary;
        }
        public Teacher(string department, string mainsubkect, decimal basesalary, int experienceyeras) : this(department, mainsubkect, basesalary)
        {
            ExperienceYears = experienceyeras;
        }

        public void ShowTeacherInfo()
        {
            Console.WriteLine($"Department:{Department},MainSubject:{MainSubject},BaseSalary:{BaseSalary},ExperienceYears:{ExperienceYears}");

        }
        public decimal CalculateSalary()
        {
            decimal result=BaseSalary+(ExperienceYears*50);
            return result;
        }
    }
}
