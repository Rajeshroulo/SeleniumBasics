using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Seleniumbasicprogram.News
{
    public class YcombinatorNews : NewsSite
    {
        Dictionary<int, string> dict = new Dictionary<int, string>();
        List<string> headings = new List<string>();
        List<int> score = new List<int>();

        [Test]    
        public void PointsAndnews()
        {
            try
            {
                IList<IWebElement> news = driver.FindElements(By.ClassName("storylink"));

                IList<IWebElement> points = driver.FindElements(By.ClassName("score"));

                for (int i = 0; i < points.Count; i++)
                {
                    string value = points[i].Text;
                    string onlyvalue = value.Replace("points", "");
                    score.Add(int.Parse(onlyvalue));
                    Console.WriteLine(onlyvalue);

                    string text = news[i].Text;
                    headings.Add(text);
                    Console.WriteLine(text);
                }


                for (int i = 0; i < score.Count; i++)
                {
                    if (!dict.ContainsKey(score[i]))
                    {
                        dict.Add(score[i], headings[i]);
                    }
                }

                foreach (KeyValuePair<int, string> keyValue in dict)
                {
                    Console.WriteLine(keyValue);
                }

                var word = headings.SelectMany(r => r.Split(new[] { " " },
                                                     StringSplitOptions.RemoveEmptyEntries))
                                     .GroupBy(r => r).OrderByDescending(r => r.Count())
                                     .Select(r => r.Key).FirstOrDefault();
                Console.WriteLine("most repeated word is =   " + word);

                var highestPointsNews = dict.OrderBy(r => r.Key).Last();
                Console.WriteLine("News with highest points =   " + highestPointsNews);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        
        }

       
    } 
}
