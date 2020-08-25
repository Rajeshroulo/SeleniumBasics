using NUnit.Framework;

namespace Bookswagon.Browsers
{
    [TestFixture]
    [Parallelizable]
    public class ChromeTest : Browser
    {
        public ChromeTest() : base(BrowserType.Chrome)
        {

        }
        [Test]
        public void ChromeBrowser()
        {
            driver.Navigate().GoToUrl("http://www.Seleniumhq.org");           
        }        
    }

    [TestFixture]
    [Parallelizable]
    public class FirefoxTest : Browser
    {
        public FirefoxTest() : base(BrowserType.Firefox)
        {

        }

        [Test]
        public void FirefoxBrowser()
        {
            driver.Navigate().GoToUrl("http://www.selenium.com");           
        }
    }
}
