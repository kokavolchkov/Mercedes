using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Pages
{
    /// <summary>
    /// BasePage class
    /// Receives webdriver instance
    /// Passes webdriver instance forward to nested classes
    /// Has WaitForElementToLoad common method
    /// Has ElementIsDisplayed common method
    /// </summary>
    public class BasePage
    {
        protected IWebDriver WebDriver { get; private set; }
        public WebDriverWait Wait(int time = 10) => new WebDriverWait(WebDriver, TimeSpan.FromSeconds(time));

        protected BasePage(IWebDriver driver)
        {
            WebDriver = driver;
        }
    }
}
