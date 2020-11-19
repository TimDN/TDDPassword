using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PasswordValidation.UnitTest
{
    [TestClass]
    public class PasswordValidatorTests
    {
        [TestMethod]
        public void IsValid_PasswordLongerThan6Char_ReturnsTrue()
        {
            var passwordValidator = new PasswordValidator();

            var actual = passwordValidator.IsValid("1234567");

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void IsValid_PasswordShorterThan7Char_ReturnsFalse()
        {
            var passwordValidator = new PasswordValidator();

            var actual = passwordValidator.IsValid("123456");

            Assert.IsFalse(actual);
        }

    }
}
