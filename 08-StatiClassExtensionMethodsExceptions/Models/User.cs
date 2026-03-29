using System;
using System.Collections.Generic;
using System.Text;

namespace _08_StatiClassExtensionMethodsExceptions.Models
{
    internal class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsLocked { get; set; }=false;
        public int FailedAttempts { get; set; } = 0;

        public User()
        {
            
        }
        public User(string username,string password)
        {
            UserName = username;
            Password = password;
        }
    }
}
