using OpenQA.Selenium;
using Automation.Helpers;
using Automation.Pages;

namespace Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        #region Locators
        public IWebElement CollectionAndAccessoriesLink
        {
            get { return WebDriver.FindElementByCssSelector(".dcp-nav__link.ng-binding"); }            
        }

        public IWebElement Spinner
        {
            get { return WebDriver.FindElementByCssSelector(".dcp-loader"); }
        }

        public bool SpinnerExists()
        {
            return WebDriver.ExistElementByCssSelector(".dcp-loader", 5);
        }

        public IWebElement CloseCookiesButton
        {
            get { return WebDriver.FindElementByCssSelector("#button-text"); }
        }

        public HomePage OpenHomePage()
        {
            WebDriver.Navigate().GoToUrl("https://shop.mercedes-benz.com/en-gb/collection/");

            return this;
        }

        public void CloseCookiesButtonClick()
        {
            CloseCookiesButton.Click();
        }

        public IWebElement AllProducts
        {
            get { return WebDriver.FindElementByCssSelector(".shopnav-flyout__nav-link.ng-binding.ng-scope"); }
        }

        public IWebElement SeeAllProductsButton
        {
            get { return WebDriver.FindElementByCssSelector(".container.container-within .wb-e-btn-2"); }
        }
        #endregion

        /// <summary>
        /// Click the All products button
        /// </summary>
        public void AllProductsClick()
        {
            AllProducts.Click();
        }

        /// <summary>
        /// Click the See all products button
        /// </summary>
        public void SeeAllProductsButtonClick()
        {
            SeeAllProductsButton.Click();
        }

        /// <summary>
        /// Open the Collection and Accessories page
        /// </summary>
        public void OpenCollectionAndAccessoriesPage()
        {
            CollectionAndAccessoriesLink.Click();
        }

        /// <summary>
        /// Waits for spinner ti disappear
        /// </summary>
        /// <param name="sec"></param>
        /// <returns></returns>
        public HomePage WaitForSpinnerToDisappear(int sec = 60)
        {
            if (SpinnerExists())
                WebDriverHelper.WaitForCondition(() => !Spinner.Displayed, sec);

            return this;
        }

        /// <summary>
        /// Waits for spinner to appear
        /// </summary>
        /// <param name="sec"></param>
        /// <returns></returns>
        public HomePage WaitForSpinner(int sec = 60)
        {
            if (!SpinnerExists())
                WebDriverHelper.WaitForCondition(() => Spinner.Displayed, sec);

            return this;
        }

        /// <summary>
        /// Clicks the Back browser button
        /// </summary>
        /// <returns></returns>
        public HomePage BrowserNavigateBack()
        {
            WebDriver.Navigate().Back();
            WaitForSpinnerToDisappear();
            return this;
        }
    }
}