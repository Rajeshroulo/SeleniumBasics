using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniumbasicprogram.Pictures
{
  public class Bridgelabz
  {
      [Test]
      public void Screenshot()
      {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.bridgelabz.com/";
            driver.Manage().Window.Maximize();
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("Bridgelab.jpeg", ScreenshotImageFormat.Jpeg);
            driver.Quit();
      }

     

  }
}
