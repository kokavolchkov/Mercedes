using Automation.Helpers;
using Automation.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WireAutomation.Helpers;

namespace WireAutomation.PageObjects
{
    public class AddressDeliveryPage : BasePage
    {
        public AddressDeliveryPage(IWebDriver driver) : base(driver)
        {
        }

        #region Locators
        public IWebElement Email
        {
            get { return WebDriver.FindElementByCssSelector("#dcp-login-guest-user-email"); }
        }

        public List<IWebElement> SalutationList
        {
            get { return WebDriver.FindElementsByCssSelector(".ng-scope.wb-e-radio-3__wrapper .dcp-form-radio-group__label"); }
        }

        public IWebElement PlaceOrderAsGuestButton
        {
            get { return WebDriver.FindElementByCssSelector("[data-testid = 'co-order-process-login-guest-user-cta']"); }
        }

        public IWebElement FirstNameField
        {
            get { return WebDriver.FindElementByCssSelector("#co_payment_address-firstName"); }
        }

        public IWebElement LastNameField
        {
            get { return WebDriver.FindElementByCssSelector("#co_payment_address-lastName"); }
        }

        public IWebElement StreetNumberField
        {
            get { return WebDriver.FindElementByCssSelector("#co_payment_address-line2"); }
        }

        public IWebElement StreetNameField
        {
            get { return WebDriver.FindElementByCssSelector("#co_payment_address-line1"); }
        }

        public IWebElement CityField
        {
            get { return WebDriver.FindElementByCssSelector("#co_payment_address-town"); }
        }

        public IWebElement PostCodeField
        {
            get { return WebDriver.FindElementByCssSelector("#co_payment_address-postalCode"); }
        }

        public IWebElement ContinueToPaymentTypeButton
        {
            get { return WebDriver.FindElementByCssSelector(".dcp-co-func-footer__cta-bar [data-ng-click='gotoNextStep()']"); }
        }

        public IWebElement ShippingPrice
        {
            get { return WebDriver.FindElementsByCssSelector(".dcp-co-delivery-mode-section__entry")[0]; }
        }

        #endregion

        /// <summary>
        /// Enter Email to the field
        /// </summary>
        /// <param name="email"></param>
        public void EnterEmail(string email)
        {
            ScenarioContext.Current["Email"] = email;
            Email.SendKeys(email);
        }

        /// <summary>
        /// Click the Place order as guest button
        /// </summary>
        public void PlaceOrderAsGuestButtonClick()
        {
            PlaceOrderAsGuestButton.Click();
        }

        /// <summary>
        /// Set the salutation to MR
        /// </summary>
        public void SetSalutationToMr()
        {
            SalutationList.ElementAt(0).Click();
        }

        /// <summary>
        /// Enter first name 
        /// </summary>
        /// <param name="firstName"></param>
        public void EnterFirstName(string firstName)
        {
            ScenarioContext.Current["FirstName"] = firstName;
            FirstNameField.SendKeys(firstName);
        }

        /// <summary>
        /// Enter last name
        /// </summary>
        /// <param name="lastName"></param>
        public void EnterLastName(string lastName)
        {
            ScenarioContext.Current["LastName"] = lastName;
            LastNameField.SendKeys(lastName);
        }

        /// <summary>
        /// Enter street number
        /// </summary>
        /// <param name="streetNumber"></param>
        public void EnterStreetNumber(string streetNumber)
        {
            ScenarioContext.Current["StreetNumber"] = streetNumber;
            StreetNumberField.SendKeys(streetNumber);
        }

        /// <summary>
        /// Enter street name
        /// </summary>
        /// <param name="streetName"></param>
        public void EnterStreetName(string streetName)
        {
            ScenarioContext.Current["StreetName"] = streetName;
            StreetNameField.SendKeys(streetName);
        }

        /// <summary>
        /// Enter city
        /// </summary>
        /// <param name="city"></param>
        public void EnterCity(string city)
        {
            ScenarioContext.Current["City"] = city;
            CityField.SendKeys(city);
        }

        /// <summary>
        /// Enter postcode
        /// </summary>
        /// <param name="postcode"></param>
        public void EnterPostCode(string postcode)
        {
            ScenarioContext.Current["PostCode"] = postcode;
            PostCodeField.SendKeys(postcode);
        }

        /// <summary>
        /// Save the shipping price
        /// </summary>
        public void SaveShippingPrice()
        {
            ScenarioContext.Current["ShippingPrice"] = DataHelper.GetOnlyDigitsFromString(ShippingPrice.Text);
        }

        /// <summary>
        /// Click the Continue to paymrnt type button
        /// </summary>
        public void ContinueToPaymentTypeButtonClick()
        {
            ContinueToPaymentTypeButton.Click();
        }
    }
}
