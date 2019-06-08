using OpenQA.Selenium;

namespace Automation
{
    /// <summary>
    /// WebDriverContainer class
    /// Has webdriver instance
    /// Is used in the InitializeScenario class
    /// </summary>
    public class WebDriverContainer
    {
        public IWebDriver WebDriver { get; private set; }

        public WebDriverContainer(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
    }
}