using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace OrangeHRMTest.Extensions
{
    public static class WebDriverExtensions
    {
        private readonly static TimeSpan _defaultTimeSpan = TimeSpan.FromSeconds(5);
        public static IWebElement WaitForElementToBeVisible(this IWebDriver webDriver, By element)
        {
            var wait = new WebDriverWait(webDriver, _defaultTimeSpan);
            return wait.Until(ExpectedConditions.ElementIsVisible(element));
        }

        public static IWebElement WaitForElementToExists(this IWebDriver webDriver, By element)
        {
            var wait = new WebDriverWait(webDriver, _defaultTimeSpan);
            return wait.Until(ExpectedConditions.ElementExists(element));
        }
    }
}
