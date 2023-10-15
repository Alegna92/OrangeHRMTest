using OpenQA.Selenium;
using OrangeHRMTest.Elements;
using OrangeHRMTest.Extensions;

namespace OrangeHRMTest.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _webDriver;
        public InputElement UsernameElement => new InputElement(_webDriver.FindElement(By.Name("username")));
        public InputElement PasswordElement => new InputElement(_webDriver.FindElement(By.Name("password")));
        public ButtonElement LoginElement => new ButtonElement(_webDriver.FindElement(By.CssSelector(".orangehrm-login-button")));

        public LoginPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public void WaitTillIsLoaded()
        {
            _webDriver.WaitForElementToExists(By.CssSelector(".orangehrm-login-branding"));
        }

    }
}
