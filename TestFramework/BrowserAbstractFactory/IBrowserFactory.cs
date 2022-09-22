using OpenQA.Selenium;
using TestFramework.Config;

namespace TestFramework.BrowserAbstractFactory;

public interface IBrowserFactory
{
    IWebDriver Create(TestSettings settings);
}