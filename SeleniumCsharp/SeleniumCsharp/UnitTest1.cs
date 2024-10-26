using System;
using Xunit; 
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

public class SeleniumTests : IDisposable
{
    private readonly IWebDriver driver;

    public SeleniumTests()
    {
        driver = new ChromeDriver(); 
    }

    public void Dispose()
    {
        driver.Quit(); 
    }

    [Fact]
    public void TestFirstWebsite()
    {
        driver.Navigate().GoToUrl("https://www.wikipedia.org/");
        Xunit.Assert.Contains("Wikipedia", driver.Title);
        var element = driver.FindElement(By.Id("search"));
        Xunit.Assert.True(element.Displayed);
    }

    [Fact]
    public void TestSecondWebsite()
    {
        driver.Navigate().GoToUrl("https://www.err.ee/");
        Xunit.Assert.Contains("ERR", driver.Title);
        var anotherElement = driver.FindElement(By.ClassName("site-logo"));
        Xunit.Assert.True(anotherElement.Displayed);
    }
}