using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections;

namespace Seleniumbasicprogram.Pictures
{
   public class Bridgelabz
   {   
      [SetUp]      
      public void InitializeBrowser()
      {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

      }

      

        public IWebDriver driver;
        
      [Test,Author("Rajesh","rajraval017@gmail.com")]
      [Description("Take screenshot")]
      public void Screenshot()
      {
            driver.Url = "https://www.bridgelabz.com/";
            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile(@"C:\Users\HP\source\repos\Seleniumbasicprogram\Seleniumbasicprogram\Pictures\\Bridgelab.jpeg", ScreenshotImageFormat.Jpeg);
            driver.Quit();
      }

      [Test, Author("Rajesh", "rajraval017@gmail.com")]
      [TestCaseSource("Datalinks")]
      public void SourceTest(String url)
      {

            try
            {
                driver.Url = url;
                driver.FindElement(By.Id("email")).SendKeys("9736373828");
            }
                
            catch(Exception e)
            {
                ITakesScreenshot sc = driver as ITakesScreenshot;
                Screenshot st = sc.GetScreenshot();
                st.SaveAsFile(@"C:\Users\HP\source\repos\Seleniumbasicprogram\Seleniumbasicprogram\Pictures\\fb.jpeg", ScreenshotImageFormat.Jpeg);
                Console.WriteLine(e.StackTrace);
                throw;
            }

      }

       public static IList Datalinks()
       {
            ArrayList list = new ArrayList();
            list.Add("https://www.facebook.com");
            return list;

       }

       [TearDown]
       public void closeBrowser()
       {
            driver.Quit();
       }

    }
}
