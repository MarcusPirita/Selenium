using OpenQA.Selenium;

[Test]
public void test_search()
{
    driver.Url = test_url;
    System.Threading.Thread.Sleep(2000);
    IWebElement searchText = driver.FindElement(By.CssSelector("[name = 'q']"));

    searchText.SendKeys("LambdaTest");

    ............................................................................
}