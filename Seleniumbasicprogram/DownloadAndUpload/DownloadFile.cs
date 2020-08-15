using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Threading;

namespace Seleniumbasicprogram.DownloadAndUpload
{
    public class DownloadFile
    {
       public static IWebDriver driver;
       public static ChromeOptions options;

        [SetUp]
        public void InitializeBrowser()
        {
            options = new ChromeOptions();
            driver = new ChromeDriver(options);
            options.AddArguments("start-maximized");
            driver.Url = "http://uitestpractice.com/Students/Widgets";

        }

        [Test]
        public static void VerifyDownload()
        {
            String expectedFilePath = @"C:\Users\HP\Downloads\images.png";
            bool fileExists = false;

            options.AddUserProfilePreference("download.default_directory", @"C:\Users\HP\Downloads\images.png");

            driver.FindElement(By.XPath("//button/a")).Click();
            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until<bool>(x => fileExists = File.Exists(expectedFilePath));

                FileInfo info = new FileInfo(expectedFilePath);

                Assert.AreEqual("images.png", info.Name);

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (File.Exists(expectedFilePath))
                    File.Delete(expectedFilePath);
            }

        }

        [Test]
        public void VerifyUpload()
        {
             driver.FindElement(By.Id("image_file")).SendKeys(@"C:\Users\HP\Downloads\Honeywell.jpg");
            driver.FindElement(By.XPath("//input[@type = 'button']")).Click();

            Thread.Sleep(5000);
        }

        

        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}
