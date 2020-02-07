using NUnit.Framework;
using NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using AssimaDemo.PageObjects;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System.Runtime.InteropServices;

namespace AssimaDemo.config
{
    public class Config
    {
        protected IWebDriver driver;
        protected string currDir = System.IO.Directory.GetCurrentDirectory();
        public static ExtentV3HtmlReporter htmlReporter;
        public static AventStack.ExtentReports.ExtentReports extent;
        public static ExtentTest test;

        public static bool isWindows = System.Runtime.InteropServices.RuntimeInformation
                                               .IsOSPlatform(OSPlatform.Windows); 
           
        public static bool isMac = System.Runtime.InteropServices.RuntimeInformation
                                               .IsOSPlatform(OSPlatform.OSX);


        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.Url ="https://www.github.com/";
        }

        [OneTimeSetUp]
        public void ExtentStart()
        {
            var reportPath = "";

            string reportTime = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz");
            if (isWindows)
            {   
                reportPath = currDir.Replace("\\bin\\Debug\\netcoreapp3.1", "\\GeneratedReports\\");
            }
            else if (isMac)
            {
                reportPath = currDir.Replace("/bin/Debug/netcoreapp3.1", "/GeneratedReports/");
            }

            extent = new AventStack.ExtentReports.ExtentReports();
            htmlReporter = new ExtentV3HtmlReporter(reportPath + "AutomatedTestReport-" + ".html");
            extent.AttachReporter(htmlReporter);
            
        }

        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush(); 
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }

    }   
}