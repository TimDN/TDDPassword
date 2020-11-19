﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PasswordValidation.UnitTest
{
    [TestClass]
    public class PasswordValidatorTests
    {
        [DataRow("1234567Ab!")]
        [DataRow("SolarPower123!")]
        [DataTestMethod]
        public void IsValid_UsingAValidPassword_ReturnsTrue(string password)
        {
            var passwordValidator = new PasswordValidator();

            var actual = passwordValidator.IsValid(password);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsValid_PasswordShorterThan7Char_ReturnsFalse()
        {
            var passwordValidator = new PasswordValidator();

            var actual = passwordValidator.IsValid("123456");

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void IsValid_PasswordMissingUpperCaseCharacter_ReturnsFalse()
        {
            var passwordValidator = new PasswordValidator();

            var actual = passwordValidator.IsValid("1234567");

            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void IsValid_PasswordMissingLowerCaseCharacter_ReturnsFalse()
        {
            var passwordValidator = new PasswordValidator();

            var actual = passwordValidator.IsValid("1234567A");

            Assert.IsFalse(actual);
        }
    }
}
