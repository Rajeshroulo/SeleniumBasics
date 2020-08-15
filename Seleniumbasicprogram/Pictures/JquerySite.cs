using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniumbasicprogram.Pictures
{
   public class JquerySite
   {
        public IWebDriver driver;
        [SetUp]
        public void InitializeBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://api.jqueryui.com/tooltip/";
        }

        [Test]
        public void DownloadSelenium()
        {
            string tooltip= driver.FindElement(By.XPath("//li[@class='project jquery']//a[contains(text(),'jQuery')]")).GetAttribute("title");
            Console.WriteLine("Tooltip is = " + tooltip);

            Assert.AreEqual("jQuery", tooltip);
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Quit();
        }

    }
}
