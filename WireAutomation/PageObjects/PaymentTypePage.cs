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
    public class PaymentTypePage : BasePage
    {
        public PaymentTypePage(IWebDriver driver) : base (driver)
        {
        }

        #region Locators
        public IWebElement CreditCard
        {
            get { return WebDriver.FindElementByCssSelector("[data-testid = 'dcp-co-payment-modes_options-CREDITCARD-label']"); }
        }

        public IWebElement MasterCard
        {
            get { return WebDriver.FindElementByCssSelector("[for = 'mastercard']"); }
        }

        public IWebElement ContinueToVerificationAndOrderPlacementButton
        {
            get { return WebDriver.FindElementByCssSelector(".dcp-co-func-footer__cta-bar .wb-e-btn-1"); }
        }

        #endregion

        /// <summary>
        /// Sets the Payment type to the Credit card
        /// </summary>
        public void PaymentTypeIsCreditCard()
        {
            CreditCard.Click();
        }

        /// <summary>
        /// Sets the Credit card type to the MasterCard
        /// </summary>
        public void CreditCardTypeIsMasterCard()
        {
            ScenarioContext.Current["CreitCardType"] = MasterCard.Text.ToString();
            MasterCard.Click();
        }

        /// <summary>
        /// Clicks the continue to verification and order placement button
        /// </summary>
        public void ContinueToVerificationAndOrderPlacementButtonClick()
        {
            ContinueToVerificationAndOrderPlacementButton.Click();
        }
    }
}
