using NUnit.Framework;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;


[TestFixture]
public class TestProgram
{
    private IWebDriver driver;
    [SetUp]
    public void SetupTest()
    {
        ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"/Users/usamarashid/Downloads", "chromedriver");
        service.Port = 64445;
        driver = new ChromeDriver(service);
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        driver.Url ="https://code.visualstudio.com/";
    }
    [TearDown]
    public void TeardownTest()
    {
        driver.Quit();
    }

    public AventStack.ExtentReports.ExtentReports extent =  new AventStack.ExtentReports.ExtentReports();

    [OneTimeSetUp]
    public void ExtentStart()
    {
        extent = new AventStack.ExtentReports.ExtentReports();
        var htmlReporter = new ExtentHtmlReporter("/Users/usamarashid/Desktop/AssimaDemo/MyReport.html");
        extent.AttachReporter(htmlReporter);
    }

    [OneTimeTearDown]
    public void ExtentClose()
    {
        extent.Flush(); 
    }

    [Test]
    public void testMethod()
    {
        ExtentTest test;
        test = extent.CreateTest("testMethod").Info("Test Started");
        String title = driver.Title;
        System.Console.WriteLine("title of site is : " +title);
        test.Log(Status.Info,"Chrome browser launched!");
        IWebElement button = driver.FindElement(By.XPath("//*[@id=\"download-buttons\"]/div[1]/button[1]"));
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        test.Log(Status.Info,"Look for Download button!");
        Assert.AreEqual("Download for Mac\nStable Build" , button.Text);
        test.Log(Status.Info,"Button found successfully!");
    }
}