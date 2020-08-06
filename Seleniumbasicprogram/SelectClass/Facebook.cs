using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Seleniumbasicprogram.SelectClass
{
  public class FaceBook
    {
        public IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://facebook.com");
            driver.Manage().Window.Maximize();

        }

       

        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }

        
    }
}
