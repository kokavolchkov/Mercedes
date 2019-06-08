using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation.Helpers
{
    public static class WebDriverExtensions
    {
        /// <summary>
        /// Method finds and element
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="by"></param>
        /// <param name="timeoutinseconds"></param>
        /// <returns>IWebElement</returns>
        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutinseconds = 10)
        {
            return WebDriverHelper.Retry(() => driver.FindElement(by), timeoutinseconds);
        }

        /// <summary>
        /// Method finds element by Css Selector
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="selector"></param>
        /// <param name="timeoutinseconds"></param>
        /// <returns>IWebElement</returns>
        public static IWebElement FindElementByCssSelector(this IWebDriver driver, string selector, int timeoutinseconds = 10)
        {
            return FindElement(driver, By.CssSelector(selector), timeoutinseconds);
        }

        /// <summary>
        /// Methods checks if element exists
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="cssSelector"></param>
        /// <param name="timeoutinseconds"></param>
        /// <returns>bool</returns>
        public static bool ExistElementByCssSelector(this IWebDriver driver, string cssSelector, int timeoutinseconds = 10)
        {
            try
            {
                FindElementByCssSelector(driver, cssSelector, timeoutinseconds);
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Method finds list of elements
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="by"></param>
        /// <param name="attempts"></param>
        /// <returns>List IWebElements</returns>
        public static List<IWebElement> FindElements(this IWebDriver driver, By by, int attempts = 10)
        {
            WebDriverHelper.WaitForCondition(() => driver.FindElements(by).Count > 0, attempts);
            return driver.FindElements(by).ToList();
        }

        /// <summary>
        /// Method finds list of elements
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="selector"></param>
        /// <returns>List IWebElements</returns>
        public static List<IWebElement> FindElementsByCssSelector(this IWebDriver driver, string selector)
        {
            return FindElements(driver, By.CssSelector(selector));
        }
    }
}
