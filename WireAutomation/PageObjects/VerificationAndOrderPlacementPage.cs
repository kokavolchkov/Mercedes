using Automation.Helpers;
using Automation.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WireAutomation.Helpers;

namespace WireAutomation.PageObjects
{
    public class VerificationAndOrderPlacementPage : BasePage
    {
        public VerificationAndOrderPlacementPage(IWebDriver driver) : base(driver)
        {
        }

        #region Locators
        public IWebElement InvoiceAddress
        {
            get { return WebDriver.FindElementsByCssSelector(".dcp-co-order-data-panel__content")[0]; }
        }

        public IWebElement DeliveryAddress
        {
            get { return WebDriver.FindElementsByCssSelector(".dcp-co-order-data-panel__content")[1]; }
        }

        public IWebElement PaymentType
        {
            get { return WebDriver.FindElementsByCssSelector(".dcp-co-order-data-panel__content")[3]; }
        }

        public IWebElement Amount
        {
            get { return WebDriver.FindElementByCssSelector("[data-testid='co-order-header-value']"); }
        }

        #endregion

        /// <summary>
        /// Compares the First and Last name in the Invoice address with First and Last name from the previous page
        /// </summary>
        /// <returns>bool</returns>
        public bool InvoiceAddressNameIsCorrect()
        {
            var firstName = ScenarioContext.Current["FirstName"].ToString();
            var lastName = ScenarioContext.Current["LastName"].ToString();

            try
            {
                return InvoiceAddress.Text.Contains(firstName + " " + lastName);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Compares the Address in the Invoice address with address name from the previous page
        /// </summary>
        /// <returns>bool</returns>
        public bool InvoiceAddressStreetIsCorrect()
        {
            var streetNumber = ScenarioContext.Current["StreetNumber"].ToString();
            var streetName = ScenarioContext.Current["StreetName"].ToString();

            try
            {
                return InvoiceAddress.Text.Contains(streetName + " " + streetNumber);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Compares the City and Postcode in the Invoice address with City and Postcode name from the previous page
        /// </summary>
        /// <returns>bool</returns>
        public bool InvoiceAddressCityIsCorrect()
        {
            var city = ScenarioContext.Current["City"].ToString();
            var postcode = ScenarioContext.Current["PostCode"].ToString();
            try
            {
                return InvoiceAddress.Text.Contains(postcode + " " + city);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Compares the Email in the Invoice address with Email from the previous page
        /// </summary>
        /// <returns>bool</returns>
        public bool InvoiceAddressEmailIsCorrect()
        {
            var email = ScenarioContext.Current["Email"].ToString();
            try
            {
                return InvoiceAddress.Text.Contains(email);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Compares the First and Last name in the Delivery address with First and Last name from the previous page
        /// </summary>
        /// <returns>bool</returns>
        public bool DeliveryAddressNameIsCorrect()
        {
            var firstName = ScenarioContext.Current["FirstName"].ToString();
            var lastName = ScenarioContext.Current["LastName"].ToString();
            try
            {
                return DeliveryAddress.Text.Contains(firstName + " " + lastName);
            }
            catch
            {
                return false;
            }
            
        }

        /// <summary>
        /// Compares the Address in the Delivery address with Address from the previous page
        /// </summary>
        /// <returns>bool</returns>
        public bool DeliveryAddressStreetIsCorrect()
        {
            var streetNumber = ScenarioContext.Current["StreetNumber"].ToString();
            var streetName = ScenarioContext.Current["StreetName"].ToString();
            try
            {
                return DeliveryAddress.Text.Contains(streetNumber + " " + streetName);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Compares the Payment type in the Delivery address with Payment type from the previous page
        /// </summary>
        /// <returns>bool</returns>
        public bool PaymentTypeIsCorrect()
        {
            var creditCardType = ScenarioContext.Current["CreitCardType"].ToString();
            try
            {
                return PaymentType.Text.Contains(creditCardType);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Compares the Amount in the Amount type from the previous page
        /// </summary>
        /// <returns>bool</returns>
        public bool AmountIsCorrect()
        {
            var productPrice = DataHelper.StringToFloat(ScenarioContext.Current["ProductPrice"].ToString());
            var shippingPrice = DataHelper.StringToFloat(ScenarioContext.Current["ShippingPrice"].ToString());
            var amount = DataHelper.StringToFloat(Amount.Text.TrimStart('£'));

            try
            {
                var productPriceAndShippingPriceSum = productPrice + shippingPrice;
                return amount == productPriceAndShippingPriceSum;
            }
            catch
            {
                return false;
            }
        }
    }
}
