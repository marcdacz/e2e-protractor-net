using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using Protractor;
using System;

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
                    var cap = DesiredCapabilities.Chrome();
                    cap.SetCapability("version", "");
                    cap.SetCapability("platform", "LINUX");
                    webDriver = new RemoteWebDriver(new Uri("http://localhost:4446/wd/hub"), cap);
                    break;               
            }
            DriverContext.NgDriver = new NgWebDriver(webDriver);
            DriverContext.NgDriver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(5);
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
