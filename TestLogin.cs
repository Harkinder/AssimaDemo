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
        
        [Test]
        public void LoginToGithub()
        {
           var dataPath = currDir.Replace("/bin/Debug/netcoreapp3.1", "/Data/");
           List<string> data = loadCsvFile(dataPath + "credentials.csv");
           string dataFromCSV = data.ElementAt(1);
           string[] credentials = dataFromCSV.Split(';');

           test = extent.CreateTest("testLoginMethod").Info("Test Started"); 

           Login login = new Login(driver);
           test.Log(Status.Info,"Checking for Sign In button...");
           Assert.IsTrue(login.signInBtn.Displayed);
           test.Log(Status.Info,"Clicking on Sign In button...");
           login.signInBtn.Click(); 
           Assert.IsTrue(login.username_txtfield.Displayed);
           test.Log(Status.Info,"Entering username...");
           login.enterUsername(credentials[0]);
           Assert.IsTrue(login.passwrd_txtfield.Displayed);
           test.Log(Status.Info,"Entering password...");
           login.enterPassword(credentials[1]);
           Assert.IsTrue(login.loginBtn.Displayed);
           test.Log(Status.Info,"Clicking on Login Button to finally login to Github.");
           login.loginBtn.Click();
        }

        public List<string> loadCsvFile(string filePath)
        {
            var reader = new StreamReader(File.OpenRead(filePath));
            List<string> searchList = new List<string>();
            while(!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                searchList.Add(line);
            }
            return searchList;
        }
    }

}
