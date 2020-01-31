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

    public class TestSignUp
    {

        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            ChromeDriverService service = ChromeDriverService.CreateDefaultService(@"/Users/ali/Downloads", "chromedriver");
            service.Port = 64445;
            driver = new ChromeDriver(service);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url ="https://www.github.com/";
        }
   
        [Test]
        [TestCase("Alisubhani123","ali.subhani+1@tintash.com","Tintashhhh123")]
        
        public void SignUpToGithub(string username, string email, string passwrd)
        {
           Signup signup=new Signup(driver);
           signup.performSignUp(username,email,passwrd);
        }

        [Test]
        [TestCase("Ali")]
        
        public void SignUpWithWrongUsername(string usrname)
        {
           Signup signup=new Signup(driver);
           signup.SignUpWithWrongUserName(usrname);
        }

        [Test]
        [TestCase("Ali")]
        
        public void SignUpWithWrongEmail(string Email)
        {
           Signup signup=new Signup(driver);
           signup.SignUpWithWrongEmail(Email);
        }

        public void TearDown()
        {
            driver.Close();
        }
  
    }

}