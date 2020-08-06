using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Seleniumbasicprogram.ActionClass
{
  public class Student
  {
      [Test]
      public void MoveToElement()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";
            driver.Manage().Window.Maximize();
            Actions actions = new Actions(driver);
            actions.DragAndDrop(driver.FindElement(By.Id("draggable")), driver.FindElement(By.Id("droppable")))
                .Build()
                .Perform();

            Thread.Sleep(3000);
            driver.Quit();

        }


    }
}
