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

    }
}
