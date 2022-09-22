using OpenQA.Selenium;

namespace VeeamVacancies.PageObjects;

public class BasePage
{
    protected IWebDriver driver;

    public BasePage(IWebDriver driver)
    {
        this.driver = driver;
    }

    public void Navigate(string url) => driver.Navigate().GoToUrl(url);
}