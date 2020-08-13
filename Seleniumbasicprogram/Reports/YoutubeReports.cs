using OpenQA.Selenium;
using log4net;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using AventStack.ExtentReports.Model;
using AventStack.ExtentReports;
using TestAttribute = NUnit.Framework.TestAttribute;
using System.Threading;

namespace Seleniumbasicprogram.Reports
{
    public class YoutubeReports
   {
       public IWebDriver driver;

        ILog logger = LogManager.GetLogger(typeof(Program));

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://youtube.com");
            logger.Info("Enter into the youtube ");
        }

        [Test]
        public void AutomationSearch()
        {
            driver.FindElement(By.XPath("//input[@id='search']")).SendKeys("Automation");
            logger.Info("Entering text in search box");
            driver.FindElement(By.XPath("//button[@id='search-icon-legacy']//yt-icon")).Click();
            logger.Info("Clicking on serach option");
            Thread.Sleep(3000);
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
            logger.Info("Exit the browser");
        }

   }
}
