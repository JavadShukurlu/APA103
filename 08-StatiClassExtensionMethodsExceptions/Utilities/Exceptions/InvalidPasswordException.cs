using System;
using System.Collections.Generic;
using System.Text;

namespace _08_StatiClassExtensionMethodsExceptions.Utilities.Exceptions
{
    internal class InvalidPasswordException:Exception
    {
        public InvalidPasswordException()
        {
            
        }
        public InvalidPasswordException(string message):base(message) 
        {
            
        }
    }
}
