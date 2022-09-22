using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using TestFramework.Config;

namespace TestFramework.BrowserAbstractFactory;

public class InternetExplorerFactory : IBrowserFactory
{
    public IWebDriver Create(TestSettings settings)
    {
        var driverService = InternetExplorerDriverService.CreateDefaultService();
        var options = new InternetExplorerOptions();
        //options.AddArgument("--start-maximized");
        //options.AddArguments(settings.BrowserOptions);
        return new InternetExplorerDriver(driverService, options);
    }
}