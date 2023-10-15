using OpenQA.Selenium;
using OrangeHRMTest.Pages;

namespace OrangeHRMTest.StepDefinitions
{
    [Binding]
    public class LoginPageSteps
    {
        private readonly IWebDriver _webDriver;
        private readonly LoginPage _loginPage;

        public LoginPageSteps(IWebDriver webDriver)
        {
            _webDriver = webDriver;
            _loginPage = new LoginPage(_webDriver);
        }

        [Given("user waits till login page is loaded")]
        public void UserWaitsTillLoginPageIsLoaded()
        {
            _loginPage.WaitTillIsLoaded();
        }

        [When ("user sets username (.*)")]
        public void UserSetsUsername(string username)
        {   
            _loginPage.UsernameElement.SetValue(username);
        }

        [When("user sets password (.*)")]
        public void UserSetsPassword(string password)
        {
            _loginPage.PasswordElement.SetValue(password);
        }

        [When("user logs in")]
        public void UserLogsIn()
        {
            _loginPage.LoginElement.Click();
        }
    }
}
