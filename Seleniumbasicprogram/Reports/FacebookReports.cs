using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Seleniumbasicprogram
{
    public class FacebookReports
    {
        ExtentReports extent = null;
        [OneTimeSetUp]
        public void ExtentStart()
        {
           extent = new ExtentReports();
           var htmlReporter = new ExtentHtmlReporter(@"C:\Users\HP\source\repos\Seleniumbasicprogram\Seleniumbasicprogram\ExtentReports\Reports.html");
           extent.AttachReporter(htmlReporter);
        }

        [OneTimeTearDown]
        public void ExtentClose()
        {
            extent.Flush();
        }

        [Test]
        public void Facebookid()
        {
            IWebDriver driver = null;
            ExtentTest test = null;
            try
            {
                test = extent.CreateTest("Facebookid").Info("Test started");
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                test.Log(Status.Info, "Chrome Browser launched");
                driver.Url="http://facebook.com";
                IWebElement email = driver.FindElement(By.Id("email"));
                email.SendKeys("8074453962");
                test.Log(Status.Info, "Email id entered");
                driver.Quit();
                test.Log(Status.Pass, "TestReport passed");

            }
            catch(Exception e)
            {
                test.Log(Status.Fail, e.ToString());
                throw;
            }

        }
        
    }
}
