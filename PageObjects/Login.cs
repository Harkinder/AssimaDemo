using NUnit.Framework;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AssimaDemo.PageObjects
{
    class Login
    {
        private IWebDriver _driver;

        public Login(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement signInBtn => _driver.FindElement(By.XPath("/html/body/div[1]/header/div/div[2]/div[2]/a[1]"));

        public IWebElement username_txtfield => _driver.FindElement(By.Id("login_field"));

        public IWebElement passwrd_txtfield => _driver.FindElement(By.Id("password"));

        public IWebElement loginBtn => _driver.FindElement(By.Name("commit"));

        public void performLogin(string username, string password)
        {
            Console.WriteLine("Clicking on Sign In Button");
            signInBtn.Click();
            Console.WriteLine("Entering Username");
            username_txtfield.SendKeys(username);
            Console.WriteLine("Entering Password");
            passwrd_txtfield.SendKeys(password);
            Console.WriteLine("Clicking on Sign In Button to finally Login");
            loginBtn.Click();
        }
    }



}