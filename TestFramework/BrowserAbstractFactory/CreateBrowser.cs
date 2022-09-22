using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using TestFramework.Config;

namespace TestFramework.BrowserAbstractFactory;

public class CreateBrowser
{
    public IWebDriver Create(TestSettings settings)
    {
        switch (settings.BrowserType)
        {
            case BrowserTypeEnum.InternetExplorer:
                return new InternetExplorerFactory().Create(settings);
            case BrowserTypeEnum.FireFox:
                return new FireFoxFactory().Create(settings);
            case BrowserTypeEnum.Chrome:
                return new ChromeFactory().Create(settings);
            default:
                return new ChromeFactory().Create(settings);
        }
    }
}