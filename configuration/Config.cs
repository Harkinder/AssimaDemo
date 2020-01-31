using NUnit.Framework;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;

namespace AssimaDemo.config
{
    public class Config
    {
        protected IWebDriver driver;
        protected string currDir = System.IO.Directory.GetCurrentDirectory();
        

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url ="https://www.github.com/";
        }

    }


    
}
