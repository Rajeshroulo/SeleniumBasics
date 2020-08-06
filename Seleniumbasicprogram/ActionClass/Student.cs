using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniumbasicprogram.ActionClass
{
  public class Student
  {
      [Test]
      public void ActionsMoveToElement()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";
            driver.Manage().Window.Maximize();
            Actions actions = new Actions(driver);
           // actions.MoveToElement(driver.FindElement(By.Id("div2")))
            //  actions.MoveToElement(driver.FindElement(By.Id("div2")),20,20)
              actions.MoveToElement(driver.FindElement(By.Id("div2")),20,20,MoveToElementOffsetOrigin.Center)
                .ContextClick()
                .Build()
                .Perform();

            driver.Quit();

        }


    }
}
