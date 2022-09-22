using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using TestFramework.Config;

namespace TestFramework.BrowserAbstractFactory;

public class FireFoxFactory : IBrowserFactory
{
    public IWebDriver Create(TestSettings settings)
    {
        var driverService = FirefoxDriverService.CreateDefaultService();
        var options = new FirefoxOptions();
        //options.AddArgument("--start-maximized");
        options.AddArguments(settings.BrowserOptions);
        return new FirefoxDriver(driverService, options);
    }
}