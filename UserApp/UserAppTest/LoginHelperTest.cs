using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserApp;

namespace UserAppTest
{
    [TestClass]
    public class LoginHelperTest
    {
        [TestMethod]
        public void NullOrEmptyUsernameShouldFailTest()
        {
            LoginHelper sut = new LoginHelper();
            bool result = sut.ValidateCredentials(null, null);
            Assert.IsFalse(result);

            bool result1 = sut.ValidateCredentials("", null);
            Assert.IsFalse(result1);
        }

        [TestMethod]
        public void NullOrEmptyPasswordShouldFailTest()
        {
            LoginHelper sut = new LoginHelper();
            bool result = sut.ValidateCredentials("username", null);
            Assert.IsFalse(result);

            bool result1 = sut.ValidateCredentials("username", "");
            Assert.IsFalse(result1);
        }

        [TestMethod]
        public void CorrectCredentialsShoudPassTest()
        {
            LoginHelper sut = new LoginHelper();
            bool result = sut.ValidateCredentials("admin", "admin");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void UsernameCasingShouldNotAffectValidationTest()
        {
            LoginHelper sut = new LoginHelper();
            bool result = sut.ValidateCredentials("Admin", "admin");
            Assert.IsTrue(result);

            bool result1 = sut.ValidateCredentials("adMIn", "admin");
            Assert.IsTrue(result1);

            bool result2 = sut.ValidateCredentials("ADMIN", "admin");
            Assert.IsTrue(result2);
        }
    }
}
