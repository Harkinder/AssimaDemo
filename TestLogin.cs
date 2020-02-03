using NUnit.Framework;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System.Threading.Tasks;
using AssimaDemo.PageObjects;
using System.IO;


namespace AssimaDemo
{
    public class TestLogin : config.Config
    {
        public AventStack.ExtentReports.ExtentReports extent =  new AventStack.ExtentReports.ExtentReports();

        [OneTimeSetUp]
        public void ExtentStart()
        {
            string reportTime = DateTime.Now.ToString("hh:mm:ss");
            extent = new AventStack.ExtentReports.ExtentReports();
            var reportPath = currDir.Replace("/bin/Debug/netcoreapp3.1", "/GeneratedReports/");
            var htmlReporter = new ExtentV3HtmlReporter(reportPath + "TestLogin-" + reportTime + ".html");
            extent.AttachReporter(htmlReporter);
        }

        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush(); 
        }

        [Test]
        public void LoginToGithub()
        {
            
           ExtentTest test;
           test = extent.CreateTest("testLoginMethod").Info("Test Started"); 

           Login login = new Login(driver);
           test.Log(Status.Info,"Checking for Sign In button...");
           Assert.IsTrue(login.signInBtn.Displayed);
           test.Log(Status.Info,"Clicking on Sign In button...");
           login.signInBtn.Click(); 
           Assert.IsTrue(login.username_txtfield.Displayed);
           test.Log(Status.Info,"Entering username...");
           login.enterUsername("admin");
           Assert.IsTrue(login.passwrd_txtfield.Displayed);
           test.Log(Status.Info,"Entering password...");
           login.enterPassword("admin");
           Assert.IsTrue(login.loginBtn.Displayed);
           test.Log(Status.Info,"Clicking on Login Button to finally login to Github.");
           login.loginBtn.Click();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
  
    }

}
