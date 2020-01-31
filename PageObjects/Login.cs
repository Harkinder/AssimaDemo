using NUnit.Framework;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            signInBtn.Click();
            username_txtfield.SendKeys(username);
            passwrd_txtfield.SendKeys(password);
            loginBtn.Click();
        }

        public void enterUsername(string username)
        {
            username_txtfield.SendKeys(username);
        }
        public void enterPassword(string password)
        {
            passwrd_txtfield.SendKeys(password);
        }

    }



}