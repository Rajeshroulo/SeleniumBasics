using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Seleniumbasicprogram.News
{
    public class NewsSite
   {
        public IWebDriver driver;

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://news.ycombinator.com");

        }


        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }

   }
}
