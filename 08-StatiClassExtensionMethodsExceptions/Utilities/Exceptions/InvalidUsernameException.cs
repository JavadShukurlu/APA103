using System;
using System.Collections.Generic;
using System.Text;

namespace _08_StatiClassExtensionMethodsExceptions.Utilities.Exceptions
{
    internal class InvalidUsernameException:Exception
    {
        public InvalidUsernameException()
        {
            
        }
        public InvalidUsernameException(string message):base(message) 
        {
            
        }
    }
}
