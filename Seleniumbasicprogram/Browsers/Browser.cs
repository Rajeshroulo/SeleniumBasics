using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Bookswagon.Browsers
{
    public enum BrowserType
    {
        Chrome,
        Firefox
    }
   public class Browser : Drivers
   {
        private BrowserType type;

        public Browser(BrowserType browser)
        {
            type = browser;
        }

        [SetUp]
        public void Initialize()
        {
            ChooseBrowser(type);
        }

        public void ChooseBrowser(BrowserType browserType)
        {
            if (browserType == BrowserType.Chrome)
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
            }
            else if (browserType == BrowserType.Firefox)
                driver = new FirefoxDriver();
        }
   }
}
