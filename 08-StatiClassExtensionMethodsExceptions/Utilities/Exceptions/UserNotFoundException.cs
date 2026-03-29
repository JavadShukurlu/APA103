using System;
using System.Collections.Generic;
using System.Text;

namespace _08_StatiClassExtensionMethodsExceptions.Utilities.Exceptions
{
    internal class UserNotFoundException:Exception
    {
        public UserNotFoundException()
        {
            
        }
        public UserNotFoundException(string message) : base(message)
        {
            
        }
    }
}
