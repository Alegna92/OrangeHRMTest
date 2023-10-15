using Microsoft.Extensions.DependencyInjection;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SolidToken.SpecFlow.DependencyInjection;

namespace OrangeHRMTest.Support
{
    
    public static class Registration 
    {
        [ScenarioDependencies]
        public static IServiceCollection CreateGlobalContainer()
        {
            var builder = new ServiceCollection();
            builder.AddScoped<IWebDriver, ChromeDriver>();
            return builder;
        }


    }

}
