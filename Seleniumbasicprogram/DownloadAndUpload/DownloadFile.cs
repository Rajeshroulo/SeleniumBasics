using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniumbasicprogram.DownloadAndUpload
{
   public class DownloadFile
   {
        
        [Test]
        public static void VerifyDownload()
        {
            String expectedFilePath = @"C:\Users\HP\Downloads\images.png";
            bool fileExists = false;

            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("download.default_directory", @"C:\Users\HP\Downloads\images.png");

            IWebDriver driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Url = "http://uitestpractice.com/Students/Widgets";
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

            driver.Quit();
        }


    }
}
