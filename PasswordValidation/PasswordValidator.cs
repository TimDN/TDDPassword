using System;
using System.Linq;

namespace PasswordValidation
{
    public class PasswordValidator
    {
        private readonly char[] _specialCharacter = { '!', '.', '#', '%', ':' };

        public bool IsValid(string password)
        {
            if(password.Length < 7 || password.Length >= 50)
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
            if(!password.Any(e => _specialCharacter.Contains(e)))
            {
                return false;
            }
            return true;
        }
    }
}
