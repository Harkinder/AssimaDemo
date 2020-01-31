using NUnit.Framework;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AssimaDemo.config
{
    public class Config
    {
        protected IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"/Users/usamarashid/Downloads", "chromedriver");
            service.Port = 64445;
            driver = new ChromeDriver(service);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url ="https://www.github.com/";
        }

    }


    
}