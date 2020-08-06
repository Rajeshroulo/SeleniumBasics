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
   public class Country
    {
       IWebDriver driver;

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

           

            driver.Quit();
        }


    }
}
