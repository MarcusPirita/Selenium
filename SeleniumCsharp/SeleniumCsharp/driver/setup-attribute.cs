using OpenQA.Selenium.Chrome;

[SetUp]
public void start_Browser()
{
    // Local Selenium WebDriver
    driver = new ChromeDriver();
    driver.Manage().Window.Maximize();
}