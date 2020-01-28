using NUnit.Framework;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
[TestFixture]
public class TestProgram
{
    private IWebDriver driver;
    [SetUp]
    public void SetupTest()
    {
        ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"/Users/usamarashid/Downloads", "chromedriver");
        service.Port = 64444;
        driver = new ChromeDriver(service);
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        driver.Url ="https://code.visualstudio.com/";
}
    [TearDown]
    public void TeardownTest()
    {
        driver.Quit();
    }
    [Test]
    public void testMethod()
    {
        String title = driver.Title;
        System.Console.WriteLine("title of site is : " +title);
        IWebElement button = driver.FindElement(By.XPath("//*[@id=\"download-buttons\"]/div[1]/button[1]"));
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        Assert.AreEqual("Download for Mac\nStable Build" , button.Text);
    }
}