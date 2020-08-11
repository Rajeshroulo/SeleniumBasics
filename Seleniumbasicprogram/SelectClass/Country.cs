﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Seleniumbasicprogram.SelectClass
{
    public class Country
    { 
      public IWebDriver driver;

        [Test]
        public void MultiselectDropdown()
        {
            driver = new ChromeDriver();
            driver.Url = "http://uitestpractice.com/Students/Select";
            driver.Manage().Window.Maximize();
            IWebElement dropdown = driver.FindElement(By.Id("countriesMultiple"));
            SelectElement element = new SelectElement(dropdown);

              IList<IWebElement> elements = element.Options;
              Console.WriteLine(elements.Count);
              foreach(var item in elements)
              {
                  Console.WriteLine(item.Text);
              }

         /*   bool isMultiple = element.IsMultiple;
            Console.WriteLine(isMultiple); 

            element.SelectByText("India");

            Thread.Sleep(2000);

            element.SelectByIndex(1);
            Thread.Sleep(2000);

            element.DeselectAll();
            Thread.Sleep(2000); */

            driver.Quit();
        }


        
    }
}
