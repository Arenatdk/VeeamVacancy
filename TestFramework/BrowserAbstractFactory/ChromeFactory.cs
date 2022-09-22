using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestFramework.Config;

namespace TestFramework.BrowserAbstractFactory;

public class ChromeFactory: IBrowserFactory
{
    public IWebDriver Create(TestSettings settings)
    {
        var driverService = ChromeDriverService.CreateDefaultService();
        var options = new ChromeOptions();
        //options.AddArgument("--start-maximized");
        options.AddArguments(settings.BrowserOptions);
        return new ChromeDriver(driverService, options);
    }
}