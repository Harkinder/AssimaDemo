using NUnit.Framework;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace AssimaDemo.PageObjects
{
    class Signup
    {
        private IWebDriver _driver;

        public Signup(IWebDriver driver)
        {
            _driver = driver;
        }

        public IWebElement username_txtfield => _driver.FindElement(By.XPath("//*[@id='user[login]']"));

        public IWebElement email_txtfield => _driver.FindElement(By.XPath("//*[@id='user[email]']"));

        public IWebElement password_textfield => _driver.FindElement(By.XPath("//*[@id='user[password]']"));

        public IWebElement signUpBtn => _driver.FindElement(By.XPath("/html/body/div[4]/main/div[1]/div/div/div[2]/div/form/button"));
        public void performSignUp(string username, string email, string password)
        {
            Console.WriteLine("Entering Username");
            username_txtfield.SendKeys(username);
            Console.WriteLine("Entering Email");
            email_txtfield.SendKeys(email);
            Console.WriteLine("Entering Password");
            password_textfield.SendKeys(password);
            Console.WriteLine("Clicking on Sign Up Button to finally Signup");
            signUpBtn.Click();
        }

public void SignUpWithWrongUserName(string username)
    {
        Console.WriteLine("Entering Username");
        username_txtfield.SendKeys(username);
        _driver.SwitchTo().DefaultContent();
        Assert.AreEqual(_driver.FindElement(By.XPath("/html/body/div[4]/main/div[1]/div/div/div[2]/div/form/auto-check[1]/dl/dd[2]/div/div[1]")).Displayed, true);

    }

public void SignUpWithWrongEmail(string email)
        {
        Console.WriteLine("Entering Email");
        email_txtfield.SendKeys(email);
        _driver.SwitchTo().DefaultContent();
        Assert.AreEqual(_driver.FindElement(By.XPath("/html/body/div[4]/main/div[1]/div/div/div[2]/div/form/auto-check[2]/dl/dd[2]")).Displayed, true);

        }
    }
}