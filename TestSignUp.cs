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
using System.IO;

namespace AssimaDemo
{

    public class TestSignUp : config.Config
    {
   
        [Test]
        [TestCase("Alisubhani123","ali.subhani+1@tintash.com","Tintashhhh123")]
        
        public void SignUpToGithub(string username, string email, string passwrd)
        {
           test = extent.CreateTest("testSignUpToGithub").Info("Test Started"); 
           Signup signup=new Signup(driver);
           signup.performSignUp(username,email,passwrd);
        }

        [Test]
        [TestCase("Ali")]
        
        public void SignUpWithWrongUsername(string usrname)
        {
           test = extent.CreateTest("testSignUpWithWrongUsername").Info("Test Started"); 
           Signup signup=new Signup(driver);
           signup.SignUpWithWrongUserName(usrname);
        }

        [Test]
        [TestCase("Ali")]
        
        public void SignUpWithWrongEmail(string Email)
        {
           test = extent.CreateTest("testSignUpWithWrongEmail").Info("Test Started"); 
           Signup signup=new Signup(driver);
           signup.SignUpWithWrongEmail(Email);
        }
    }

}