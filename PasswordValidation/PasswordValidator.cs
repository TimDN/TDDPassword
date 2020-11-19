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

        private bool PasswordContainsRequiredCharacters(string password)
        {
            if (!password.Any(char.IsUpper) ||
                !password.Any(char.IsLower) ||
                !password.Any(char.IsDigit) ||
                !password.Any(e => _specialCharacter.Contains(e)))
            {
                return false;
            }
            return true;
        }

        private bool PasswordIsInRange(string password, int lower, int upper)
        {
            return password.Length > lower && password.Length < upper;
        }

        public bool IsValid(string password)
        {
            if(PasswordIsInRange(password, 7, _maxLength) &&
               PasswordContainsRequiredCharacters(password))
            {
                return true;
            }
            return false;
        }
    }
}
