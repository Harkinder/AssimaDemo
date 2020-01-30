using NUnit.Framework;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssimaDemo.PageObjects;

namespace AssimaDemo
{

    public class TestClass
    {

        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"/Users/usamarashid/Downloads", "chromedriver");
            service.Port = 64445;
            driver = new ChromeDriver(service);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url ="https://www.github.com/";
        }
   
        [Test]
        public void LoginToGithub()
        {
           Login login = new Login(driver);
           login.performLogin("admin", "admin");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
  
    }

}