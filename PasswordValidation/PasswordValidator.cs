using System;
using System.Linq;

namespace PasswordValidation
{
    public class PasswordValidator
    {
        public bool IsValid(string password)
        {
            if(password.Length < 7)
            {
                return false;
            }
            if (!password.Any(char.IsUpper))
            {
                return false;
            }
            if (!password.Any(char.IsLower))
            {
                return false;
            }
            if (!password.Any(char.IsDigit))
            {
                return false;
            }
            return true;
        }
    }
}
