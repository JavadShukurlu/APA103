using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace _03_ObjectClassConstructorInheritanceThisvsBase.Models
{
    internal class Person
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }

        public Person()
        {

        }
        public Person(string id) : this()
        {
            Id = id;
        }
        public Person(string id, string firstname) : this(id)
        {
            FirstName = firstname;
        }
        public Person(string id, string firstname, string lastname) : this(id, firstname)
        {
            LastName = lastname;
        }
        public Person(string id, string firstname, string lastname, int age) : this(id, firstname, lastname)
        {
            Age = age;
        }
        public Person(string id, string firstname, string lastname, int age, string email) : this(id, firstname, lastname, age)
        {
            Email = email;
        }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
        public void ShowBasicInfo()
        {
            Console.WriteLine($"Id:{Id},Age:{Age},Email:{Email}");
        }
    }
}
