using _08_StatiClassExtensionMethodsExceptions.Utilities.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace _08_StatiClassExtensionMethodsExceptions.Models
{
    internal class LoginSystem
    {
        User user = new User();
        User[] users;
       

        const int MaxAttempts = 3;


        public User[] Users=>users;
        public LoginSystem()
        {
            users = new User[]
            {
                new User("admin", "admin123"),
                new User("student", "student123"),
                new User("teacher", "teacher123")
            };

        }

        public void ValidateUsername(string username)
        {
            int sum = 0;    
            foreach(var item in username)
            {
                
                sum++;
            }

            if(sum==0 || sum < 3)
            {
                throw new InvalidUsernameException("Istifadeci adi en az 3 herfden ibaret olmalidir");
            }
        }

        public void ValidatePassword(string password)
        {
            int sum = 0;
            foreach(var item in password)
            {
                
                sum++;
            }

            if(sum==0 || sum < 6)
            {
                throw new InvalidPasswordException("Parol en az 6 simvoldan ibaret olmalidir");
            }
        }

         User FindUser(string username)
        { 

            foreach(var item in users)
            {
                if(item.UserName.Trim().ToLower() == username.Trim().ToLower())
                {
                    return item;
                }

            }

                throw new UserNotFoundException("Istifadeci tapilmadi");
        }

        public bool Login(string username,string password)
        {
            ValidateUsername(username);
            ValidatePassword(password);
           user= FindUser(username);
            if (user.IsLocked == true)
                throw new AccountLockedException("Hesab bloklanib");

            if (user.Password == password)
            {
                user.FailedAttempts = 0;
                Console.WriteLine($"Login successful!Welcome,{username}!");
                return true;

            }
            else
            {
                user.FailedAttempts++;
                int attemptsLeft = MaxAttempts - user.FailedAttempts;
                if (attemptsLeft>0)
                   throw new IncorrectPasswordException(MaxAttempts-user.FailedAttempts);
                else
                {
                    user.IsLocked = true;
                    throw new AccountLockedException("Hesab bloklanib");
                    
                }
                
            }
            
           


        }


    }


}
