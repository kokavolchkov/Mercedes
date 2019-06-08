using Automation.Helpers;
using Automation.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace WireAutomation.PageObjects
{
    public class ShoppingBasketPage : BasePage
    {
        public ShoppingBasketPage(IWebDriver driver):base(driver)
        {
        }

        #region Locators
        public IWebElement ProductName
        {
            get { return WebDriver.FindElementByCssSelector(".wb-e-link-5.ng-scope span"); }
        }

        public IWebElement ProductPrice
        {
            get { return WebDriver.FindElementByCssSelector("[data-testid = 'co-orderline-total-price']"); }
        }

        public IWebElement ContinueToAddressAndDeliveryButton
        {
            get { return WebDriver.FindElementByCssSelector(".dcp-co-func-header_cta [data-ng-click = 'gotoNextStep()']"); }
        }

        #endregion

        /// <summary>
        /// Compares the Product price from the order page with the price in the shopping basket
        /// </summary>
        /// <returns>bool</returns>
        public bool ProductPriceIsCorrect()
        {
            var productPrice = ScenarioContext.Current["ProductPrice"];

            return productPrice.Equals(ProductPrice.Text.TrimStart('£'));
        }

        /// <summary>
        /// Compares the Product name from the order page with the price in the shopping basket
        /// </summary>
        /// <returns>bool</returns>
        public bool ProductNameIsCorrect()
        {
            var productName = ScenarioContext.Current["ProductName"];

            return productName.Equals(ProductName.Text);
        }

        /// <summary>
        /// Clicks the Continue to address and delivery button
        /// </summary>
        public void ContinueToAddressAndDeliveryButtonClick()
        {
            ContinueToAddressAndDeliveryButton.Click();
        }
    }
}
