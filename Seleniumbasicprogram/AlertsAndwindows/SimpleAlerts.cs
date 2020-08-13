using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Seleniumbasicprogram.AlertsAndwindows
{
   public class SimpleAlerts
   {
        public IWebDriver driver;

        [SetUp]
        public void InitializeBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://uitestpractice.com/Students/Switchto";
        }


        [Test]
        public void SimpleAlert()
        {
            driver.FindElement(By.Id("alert")).Click();
           string text = driver.SwitchTo().Alert().Text;
            Console.WriteLine(text);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }


    }
}
