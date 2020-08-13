﻿using NUnit.Framework;
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

        [OneTimeTearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }


    }
}
