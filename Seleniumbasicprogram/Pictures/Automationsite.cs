using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Seleniumbasicprogram.Pictures
{
   public class Automationsite
   {
        public IWebDriver driver;
        [SetUp]
        public void InitializeBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://demo.automationtesting.in/Datepicker.html";
        }

        [Test]
        public void DatePickerHandling()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("document.getElementById('datepicker1').value='01/02/2013'");
            Thread.Sleep(3000);
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Quit();
        }
    }
}
