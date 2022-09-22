using System.Collections.ObjectModel;
using OpenQA.Selenium;

namespace VeeamVacancies.PageObjects;

public class VacanciesPage : BasePage
{
    #region WebElements

    private IWebElement DepartmentsElement
        => driver.FindElement(By.XPath("//button[@id='sl' and contains(text(), 'All departments')]"));

    private IWebElement DepartmentsElementsDropdown(string value)
        => driver.FindElement(By.XPath($"//a[@class='dropdown-item' and text()='{value}']"));

    private IWebElement LanguagesElement(string value = "All languages")
        => driver.FindElement(By.XPath($"//button[@id='sl' and contains(text(), '{value}')]"));

    private IWebElement LanguagesElementsDropdown(string value)
        => driver.FindElement(By.XPath($"//label[contains(@for, 'lang-option') and contains(text(), '{value}')]"));

    private ReadOnlyCollection<IWebElement> VacancieCards
        => driver.FindElements(By.XPath("//a[contains(@class, 'card') and contains(@href, 'vacancies')]"));

    #endregion

    #region Actions

    public VacanciesPage SetDepartment(string value)
    {
        DepartmentsElement.Click();
        DepartmentsElementsDropdown(value).Click();
        return this;
    }

    public VacanciesPage SetLanguage(string value)
    {
        LanguagesElement().Click();
        LanguagesElementsDropdown(value).Click();
        LanguagesElement(value).Click();
        return this;
    }

    #endregion

    #region Validators

    public VacanciesPage VerifyVacanciesCardsCount(int value)
    {
        int count = VacancieCards.Count();
        Assert.That(count, Is.EqualTo(value), $"Vacancy Cards: ");
        return this;
    }

    #endregion

    public VacanciesPage(IWebDriver driver) : base(driver)
    {
    }
}