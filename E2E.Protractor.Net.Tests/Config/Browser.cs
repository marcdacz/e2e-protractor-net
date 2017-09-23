using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.PhantomJS;
using Protractor;
using System;
using System.IO;

namespace E2E.Protractor.Net.Tests.Config
{
    public abstract class Browser
    {
        public static void Initialise()
        {
            Open();
            NavigateToHomePage();
        }

        public static void Open(BrowserType browserType = BrowserType.Chrome)
        {
            var currentDirectory = Environment.CurrentDirectory;
            IWebDriver webDriver = null;
            switch (browserType)
            {                
                case BrowserType.FireFox:
                    webDriver = new FirefoxDriver();
                    break;
                case BrowserType.Chrome:
                default:
                    webDriver = new ChromeDriver(currentDirectory);
                    break;               
            }
            DriverContext.NgDriver = new NgWebDriver(webDriver);
            DriverContext.NgDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public static void NavigateToHomePage()
        {
            DriverContext.NgDriver.Navigate().GoToUrl("http://juliemr.github.io/protractor-demo/");
        }

        public static void Close()
        {
            DriverContext.NgDriver.Quit();
        }
    }
}
