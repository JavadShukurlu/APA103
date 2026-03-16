using System;
using System.Collections.Generic;
using System.Text;

namespace _03_ObjectClassConstructorInheritanceThisvsBase.Models
{
    internal class Administrator:Person
    {
        public string Position { get; set; }
        public string Department { get; set; }
        public int AccessLevel { get; set; }

        public Administrator(string id, string firstname, string lastname, int age, string email) : base(id, firstname, lastname, age, email)
        {

        }

        public Administrator()
        {
            
        }
        public Administrator(string position):this()
        {
            Position = position;
        }
        public Administrator(string position,string department):this(position)
        {
            Department = department;
        }
        public Administrator(string position, string department, int accesslevel) : this(position, department)
        {
            AccessLevel = accesslevel;
        }

        public void ShowAdminInfo()
        {
            Console.WriteLine($"Position:{Position},Department:{Department},AccessLevel:{AccessLevel}");
        }

        public void GrantAccess(Student student)
        {
            Console.WriteLine($"{student.FirstName} {student.LastName} adli studente access verilmisdir");
        }
    }
}
