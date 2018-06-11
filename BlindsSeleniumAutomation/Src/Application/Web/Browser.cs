using System;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace BlindsSelenium
{

    public static class Browser
    {
        static IWebDriver IWebDriver = new ChromeDriver();

        public static void Goto(string url)
        {
            IWebDriver.Manage().Window.Maximize();
            IWebDriver.Url = url;
        }

        public static ISearchContext Driver
        {
            get { return IWebDriver; }
        }

         public static void Close()
        {
            IWebDriver.Quit();
        }

        public static void Dipose()
        {
            IWebDriver.Dispose();
        }

       
    }



    public class GetEnvironment
    {

        public static string GetUrl()
        {
            string url = (ConfigurationManager.AppSettings["BlindsProdUrl"]);
            return url;
        }
    }
}