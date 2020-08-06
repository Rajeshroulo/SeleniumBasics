﻿using NUnit.Framework;
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

        [Test]
        public void MonthDropdown()
        {
           IWebElement monthDropdownlist = driver.FindElement(By.XPath(".//*[@id='month']"));
            SelectElement element = new SelectElement(monthDropdownlist);
            element.SelectByValue("5");
            Thread.Sleep(3000);
            element.SelectByText("Aug");
            Thread.Sleep(3000);
            element.SelectByIndex(3);
            Thread.Sleep(2000);
            element.DeselectByIndex(3);

        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }

        
    }
}
