using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation
{
    /// <summary>
    /// Driver class
    /// Creates webdriver instance
    /// May be refactored to the WebDriverFactory class
    /// </summary>
    public static class Driver
    {
        public static IWebDriver CreateDriver()
        {
            IWebDriver driver = null;
            var browser = ConfigurationManager.AppSettings.Get("browser");
            switch (browser)
            {
                default:
                    ChromeOptions options = new ChromeOptions();
                    options.AddArguments("--incognito");
                    driver = new ChromeDriver(options);
                    driver.Manage().Window.Maximize();
                    break;
            }

            return driver;
        }
    }
}
