using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserApp;

namespace UserAppTest
{
    [TestClass]
    public class LoginFormTest
    {
        [TestMethod]
        public void EmptyUsernameAndPasswordShouldFail()
        {
            var userForm = new UserAppForm();
            var loginFrom = new LoginForm(userForm);
        }
    }
}
