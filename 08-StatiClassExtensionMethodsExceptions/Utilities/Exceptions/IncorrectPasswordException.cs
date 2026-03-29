using System;
using System.Collections.Generic;
using System.Text;

namespace _08_StatiClassExtensionMethodsExceptions.Utilities.Exceptions
{
    internal class IncorrectPasswordException: Exception
    {
        public int AttemptsLeft { get; set; }

        public IncorrectPasswordException(int attemptleft):base($"Sifre yanlisdir. Senin {attemptleft} yoxlama sansin qaldi.")
        {
            AttemptsLeft = attemptleft;
        }

        
    }
}
