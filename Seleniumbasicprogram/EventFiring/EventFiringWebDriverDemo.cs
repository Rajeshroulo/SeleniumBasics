using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;
using System;
using System.Threading;

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
            
            //Element value changing events
            eventFiringWebDriver.ElementValueChanging += EventFiringWebDriver_ElementValueChanging;
            eventFiringWebDriver.ElementValueChanged += EventFiringWebDriver_ElementValueChanged;

            //Navigation events
            eventFiringWebDriver.Navigating += EventFiringWebDriver_Navigating;
            eventFiringWebDriver.Navigated += EventFiringWebDriver_Navigated;

            eventFiringWebDriver.NavigatingForward += EventFiringWebDriver_NavigatingForward;
            eventFiringWebDriver.NavigatedForward += EventFiringWebDriver_NavigatedForward;

            eventFiringWebDriver.NavigatingBack += EventFiringWebDriver_NavigatingBack;
            eventFiringWebDriver.NavigatedBack += EventFiringWebDriver_NavigatedBack;

            //Script execution events
            eventFiringWebDriver.ScriptExecuting += EventFiringWebDriver_ScriptExecuting;
            eventFiringWebDriver.ScriptExecuted += EventFiringWebDriver_ScriptExecuted;

            //Exception thrown events
            eventFiringWebDriver.ExceptionThrown += EventFiringWebDriver_ExceptionThrown;
            
            driver = eventFiringWebDriver;

            //Click events will trigger here
            driver.FindElement(By.LinkText("Form")).Click();

            //Element value change event
            driver.FindElement(By.Id("firstname")).SendKeys("Rajesh kumar");

            //Navigation events
            driver.Navigate().GoToUrl("http://uitestpractice.com");
            driver.Navigate().Back();
            driver.Navigate().Forward();

            //Script execution events
            ((IJavaScriptExecutor)driver).ExecuteScript("alert('Javascript executing')");
            driver.SwitchTo().Alert().Accept();

            //Exception thrown events
            driver.FindElement(By.Id("Raj")).Click();

            driver.Quit();
        }

        private void EventFiringWebDriver_ExceptionThrown(object sender, WebDriverExceptionEventArgs e)
        {
            Console.WriteLine("Exception Thrown");
        }

        private void EventFiringWebDriver_ScriptExecuted(object sender, WebDriverScriptEventArgs e)
        {
            Console.WriteLine("Script Executed");
        }

        private void EventFiringWebDriver_ScriptExecuting(object sender, WebDriverScriptEventArgs e)
        {
            Console.WriteLine("Script Executing");
        }

        private void EventFiringWebDriver_NavigatedBack(object sender, WebDriverNavigationEventArgs e)
        {
            Console.WriteLine(" Navigated Back");
        }

        private void EventFiringWebDriver_NavigatingBack(object sender, WebDriverNavigationEventArgs e)
        {
            Console.WriteLine(" Navigating Back");
        }

        private void EventFiringWebDriver_NavigatedForward(object sender, WebDriverNavigationEventArgs e)
        {
            Console.WriteLine(" Navigated forward");
        }

        private void EventFiringWebDriver_NavigatingForward(object sender, WebDriverNavigationEventArgs e)
        {
            Console.WriteLine(" Navigating forward");
        }

        private void EventFiringWebDriver_Navigated(object sender, WebDriverNavigationEventArgs e)
        {
            Console.WriteLine("Element  Navigated");
        }

        private void EventFiringWebDriver_Navigating(object sender, WebDriverNavigationEventArgs e)
        {
            Console.WriteLine("Element  Navigating");
        }

        private void EventFiringWebDriver_ElementValueChanged(object sender, WebElementValueEventArgs e)
        {
            Console.WriteLine("Element value changed");
        }

        private void EventFiringWebDriver_ElementValueChanging(object sender, WebElementValueEventArgs e)
        {
            Console.WriteLine("Element value changing");
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
