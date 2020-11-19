using System;

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
            return true;
        }
    }
}
