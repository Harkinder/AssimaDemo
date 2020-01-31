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
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

namespace AssimaDemo
{

    public class TestSignUp : config.Config
    {
        public AventStack.ExtentReports.ExtentReports extent =  new AventStack.ExtentReports.ExtentReports();

        [OneTimeSetUp]
        public void ExtentStart()
        {
            extent = new AventStack.ExtentReports.ExtentReports();
            var reportPath = currDir.Replace("/bin/Debug/netcoreapp3.1", "/GeneratedReports/");
            var htmlReporter = new ExtentHtmlReporter(reportPath + "TestSignUp.html");
            extent.AttachReporter(htmlReporter);
        }

        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush(); 
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
        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
  
    }

}