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
    public class TestLogin : config.Config
    {
        [Test]
        public void LoginToGithub()
        {
           Login login = new Login(driver);
           Assert.IsTrue(login.signInBtn.Displayed);
           login.signInBtn.Click(); 
           Assert.IsTrue(login.username_txtfield.Displayed);
           login.enterUsername("admin");
           Assert.IsTrue(login.passwrd_txtfield.Displayed);
           login.enterPassword("admin");
           Assert.IsTrue(login.loginBtn.Displayed);
           login.loginBtn.Click();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
  
    }

}