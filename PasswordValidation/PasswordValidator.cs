using System;
using System.Linq;

namespace PasswordValidation
{
    public class PasswordValidator
    {
        public PasswordValidator(int maxLength = 50)
        {
            _maxLength = maxLength;
        }

        private readonly char[] _specialCharacter = { '!', '.', '#', '%', ':' };
        private readonly int _maxLength;

        public bool IsValid(string password)
        {
            if(password.Length < 7 || password.Length >= _maxLength)
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
