using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System.Threading;

namespace Seleniumbasicprogram.ActionClass
{
    public class Student
    {
        public IWebDriver driver;
        public Actions actions;
        [SetUp]
        public void InitializeBrowser()
        {
            driver = new ChromeDriver();
            driver.Url = "http://uitestpractice.com/Students/Actions";
            driver.Manage().Window.Maximize();
            actions = new Actions(driver);
        }

        [Test,Order(1)]
        public void MoveElement()
        {
            actions.MoveToElement(driver.FindElement(By.Id("div2")), 20, 20, MoveToElementOffsetOrigin.Center)
            .ContextClick().Build().Perform();
        }

        [Test,Order(2)]
        public void DragandDrop()
        {
            actions.DragAndDrop(driver.FindElement(By.Id("draggable")), driver.FindElement(By.Id("droppable")))
            .Build().Perform();
        }

        [Test,Order(3)]
        public void ActionClick()
        {
           // actions.Click(driver.FindElement(By.Name("click")))
            actions.MoveToElement(driver.FindElement(By.Name("click")))
            .Click().Build().Perform();
        }

        [Test,Order(4)]
        public void ActionDoubleClick()
        {
            //actions.DoubleClick(driver.FindElement(By.Name("dblClick")))
            actions.MoveToElement(driver.FindElement(By.Name("dblClick")))
            .DoubleClick().Build().Perform();
        }

        [Test,Order(5)]
        public void ActionClickAndHold()
        {
          // actions.ClickAndHold(driver.FindElement(By.Name("one")))    // with Parameters
           // .Release(driver.FindElement(By.Name("twelve")))
            actions.MoveToElement(driver.FindElement(By.Name("one")))    // without Parameters
            .ClickAndHold().Release().Build().Perform();
            Thread.Sleep(2000);
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}
