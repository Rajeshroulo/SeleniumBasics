using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Seleniumbasicprogram.SelectClass
{
    public class Country
    { 
      public IWebDriver driver;

        [SetUp]
        public void InitializeBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "http://uitestpractice.com/Students/Select";
        }

        [Test]
        public void SelectDropdownElements()
        {
            IWebElement dropdown = driver.FindElement(By.Id("countriesMultiple"));
            SelectElement element = new SelectElement(dropdown);

            IList<IWebElement> elements = element.Options;
            Console.WriteLine(elements.Count);
            foreach (var item in elements)
            {
                Console.WriteLine(item.Text);
            }
        }

        [Test]
        public void SelectDropdownType() 
        {
            IWebElement dropdown = driver.FindElement(By.Id("countriesMultiple"));
            SelectElement element = new SelectElement(dropdown);

            bool isMultiple = element.IsMultiple;
            Console.WriteLine(isMultiple);

        }
        
        [Test]
        public void SelectDropdownValue()
        {
            IWebElement dropdown = driver.FindElement(By.Id("countriesMultiple"));
            SelectElement element = new SelectElement(dropdown);
            element.SelectByText("India");

            Thread.Sleep(2000);

            element.SelectByIndex(1);
            Thread.Sleep(2000);

            element.DeselectAll();
            Thread.Sleep(2000);

        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();

        }

    }
}
