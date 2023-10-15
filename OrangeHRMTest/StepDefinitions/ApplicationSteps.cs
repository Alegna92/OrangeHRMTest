using OpenQA.Selenium;

namespace OrangeHRMTest.StepDefinitions
{
    [Binding]
    public class ApplicationSteps
    {
        private readonly IWebDriver _webDriver;
        public ApplicationSteps(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        [BeforeScenario]
        public void BeforeTestRunStep()
        {
            _webDriver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
        }

        [AfterScenario]
        public void AfterTestRunStep()
        {
            _webDriver.Quit();
        }
    }
}
