using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;
using System;

namespace Seleniumbasicprogram.EventFiring
{
    public class EventFiringWebDriverDemo
    {
        public IWebDriver driver;

        [Test]
        public void EventFiringDemo()
        {
            driver = new ChromeDriver();
            driver.Url = "http://uitestpractice.com";
            driver.Manage().Window.Maximize();
            EventFiringWebDriver eventFiringWebDriver = new EventFiringWebDriver(driver);

            //Click events
            eventFiringWebDriver.ElementClicking += EventFiringWebDriver_ElementClicking;
            eventFiringWebDriver.ElementClicked += EventFiringWebDriver_ElementClicked;
            driver = eventFiringWebDriver;
            driver.FindElement(By.LinkText("Form")).Click();

            driver.Quit();
        }

        private void EventFiringWebDriver_ElementClicked(object sender, WebElementEventArgs e)
        {
            Console.WriteLine("Element Clicked");  
        }

        private void EventFiringWebDriver_ElementClicking(object sender, WebElementEventArgs e)
        {
            Console.WriteLine("Element clicking");
        }
    }
}
