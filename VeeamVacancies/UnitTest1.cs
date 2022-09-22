using OpenQA.Selenium;
using TestFramework.BrowserAbstractFactory;
using TestFramework.Config;
using VeeamVacancies.PageObjects;

namespace VeeamVacancies;

public class Tests
{
    private IWebDriver driver;
    private TestSettings testSettings;

    [SetUp]
    public void Setup()
    {
        testSettings = new ConfigReader().GetTestSettings();
        driver = new CreateBrowser().Create(testSettings);
    }

    #region Init

    string departamentText = "Research & Development";
    string languageText = "English";
    int vacancyCardsCount = 13;

    #endregion

    [Test]
    public void Test1()
    {
        driver.Navigate().GoToUrl(testSettings.VacancyUrl);
        var vp = new VacanciesPage(driver)
            .SetDepartment(departamentText)
            .SetLanguage(languageText)
            .VerifyVacanciesCardsCount(vacancyCardsCount);
    }

    [TearDown]
    public void TearDown()
    {
        driver.Quit();
    }
}