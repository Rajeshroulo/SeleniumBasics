using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace Seleniumbasicprogram.ActionClass
{
    public class Student
    {
      [Test]
      public void DragandDrop()
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
