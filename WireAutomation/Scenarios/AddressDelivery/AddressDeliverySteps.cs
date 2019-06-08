using Automation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace WireAutomation.Scenarios.AddressDelivery
{
    [Binding]
    public class AddressDeliverySteps : BaseStep
    {
        [When(@"User enters email address '(.*)' to the Email address field")]
        public void WhenUserEntersEmailAddressToTheEmailAddressField(string email)
        {
            Pages.AddressDeliveryPage.EnterEmail(email);
        }

        [When(@"User clicks the Place order as guest button")]
        public void WhenUserClicksThePlaceOrderAsGuestButton()
        {
            Pages.AddressDeliveryPage.PlaceOrderAsGuestButtonClick();
            Pages.HomePage.WaitForSpinnerToDisappear();
        }

        [When(@"User sets the salutation to Mr")]
        public void WhenUserSetsTheSalutationToMr()
        {
            Pages.AddressDeliveryPage.SetSalutationToMr();
        }

        [When(@"User enters '(.*)' First name")]
        public void WhenUserEntersFirstName(string firstName)
        {
            Pages.AddressDeliveryPage.EnterFirstName(firstName);
        }

        [When(@"User enters '(.*)' Last name")]
        public void WhenUserEntersLastName(string lastName)
        {
            Pages.AddressDeliveryPage.EnterLastName(lastName);
        }

        [When(@"User enters '(.*)' Street number")]
        public void WhenUserEntersStreetNumber(string streetNumber)
        {
            Pages.AddressDeliveryPage.EnterStreetNumber(streetNumber);
        }

        [When(@"User enters '(.*)' Street name")]
        public void WhenUserEntersStreetName(string streetName)
        {
            Pages.AddressDeliveryPage.EnterStreetName(streetName);
        }

        [When(@"User enters '(.*)' city")]
        public void WhenUserEntersCity(string city)
        {
            Pages.AddressDeliveryPage.EnterCity(city);
        }

        [When(@"User enters '(.*)' postcode")]
        public void WhenUserEntersPostcode(string postcode)
        {
            Pages.AddressDeliveryPage.EnterPostCode(postcode);
        }

        [When(@"User receives Shipping price")]
        public void WhenUserReceivesShippingPrice()
        {
            Pages.AddressDeliveryPage.SaveShippingPrice();
        }


        [When(@"User clicks the Continue to payment type button")]
        public void WhenUserClicksTheContinueToPaymentTypeButton()
        {
            Pages.AddressDeliveryPage.ContinueToPaymentTypeButtonClick();
            Pages.HomePage.WaitForSpinnerToDisappear();
        }
    }
}
