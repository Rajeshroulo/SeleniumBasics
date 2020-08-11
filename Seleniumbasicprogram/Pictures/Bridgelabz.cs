using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;

namespace Seleniumbasicprogram.Pictures
{
    public class Bridgelabz
    {  

      public IWebDriver driver;  
      [Test,Author("Rajesh","rajraval017@gmail.com")]
      [Description("Take screenshot")]
      public void Screenshot()
      {
            driver = new ChromeDriver();
            driver.Url = "https://www.bridgelabz.com/";
            driver.Manage().Window.Maximize();
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(@"C:\Users\HP\source\repos\Seleniumbasicprogram\Seleniumbasicprogram\Pictures\\Bridgelab.jpeg", ScreenshotImageFormat.Jpeg);
            driver.Quit();
      }

      [Test, Author("Rajesh", "rajraval017@gmail.com")]
      [TestCaseSource("Datalinks")]
      public void SourceTest(String url)
      {

            try
            {
                driver = new ChromeDriver();
                driver.Manage().Window.Maximize();
                driver.Url = url;
                driver.FindElement(By.Id("email")).SendKeys("9736373828");
                driver.Quit();
            }
                
            catch(Exception e)
            {
                ITakesScreenshot sc = driver as ITakesScreenshot;
                Screenshot st = sc.GetScreenshot();
                st.SaveAsFile(@"C:\Users\HP\source\repos\Seleniumbasicprogram\Seleniumbasicprogram\Pictures\\fb.jpeg", ScreenshotImageFormat.Jpeg);
                Console.WriteLine(e.StackTrace);
                driver.Quit();
                throw;
            }

      }

        static IList Datalinks()
        {
            ArrayList list = new ArrayList();
            list.Add("https://www.facebook.com");
            return list;

        } 


    }
}
