using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace Seleniumbasicprogram.News
{
    public class YcombinatorNews
    {
        public IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://news.ycombinator.com");

        }

        [Test]
        public void NewsHeading()
        {
            driver.FindElement(By.ClassName("morelink")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("morelink")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.ClassName("morelink")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.LinkText("Water beetles that survive being swallowed by frogs")).Click();
            Thread.Sleep(2000);

        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }
    } 
}
