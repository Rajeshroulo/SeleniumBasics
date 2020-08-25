using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Seleniumbasicprogram.AlertsAndwindows
{
    public class SimpleAlerts
    {
        public IWebDriver driver;

        [OneTimeSetUp]
        public void InitializeBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://uitestpractice.com/Students/Switchto";
        }

        [Test,Order(1)]
        public void SimpleAlert()
        {
            driver.FindElement(By.Id("alert")).Click();
            string text = driver.SwitchTo().Alert().Text;
            Console.WriteLine(text);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
        }

        [Test,Order(2)]
        public void PropmtAlert()
        {
            driver.FindElement(By.Id("prompt")).Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().SendKeys("Rajesh");
            Thread.Sleep(2000);
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
        }

        [Test,Order(3)]
        public void SwitchFrames()
        {
            driver.SwitchTo().Frame("iframe_a");
            driver.FindElement(By.Id("name")).SendKeys("Raj");
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
        }

        [Test,Order(4)]
        public void MultipleWindows()
        {
            driver.FindElement(By.LinkText("Opens in a new window")).Click();
            Console.WriteLine("Number of windows opened" + driver.WindowHandles.Count);
            foreach(var windows in driver.WindowHandles)
            {
                Console.WriteLine(windows);
            }
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Console.WriteLine("Current window handle is" + driver.CurrentWindowHandle);
            Thread.Sleep(2000);
        }

        [OneTimeTearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}
