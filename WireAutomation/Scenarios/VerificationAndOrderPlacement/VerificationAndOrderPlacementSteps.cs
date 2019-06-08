using Automation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace WireAutomation.Scenarios.VerificationAndOrderPlacement
{
    [Binding]
    public class VerificationAndOrderPlacementSteps : BaseStep
    {
        [Then(@"Invoice address is correct")]
        public void ThenInvoiceAddressIsCorrect()
        {
            Assert.IsTrue(Pages.VerificationAndOrderPlacementPage.InvoiceAddressNameIsCorrect(), "First name or Last name are not correct");
            Assert.IsTrue(Pages.VerificationAndOrderPlacementPage.InvoiceAddressStreetIsCorrect(), "Street name or number are not correct");
            Assert.IsTrue(Pages.VerificationAndOrderPlacementPage.InvoiceAddressCityIsCorrect(), "City or postcode are not correct");
            Assert.IsTrue(Pages.VerificationAndOrderPlacementPage.InvoiceAddressEmailIsCorrect(), "Email is not correct");
        }

        [Then(@"Delivery address is correct")]
        public void ThenDeliveryAddressIsCorrect()
        {
            Assert.IsTrue(Pages.VerificationAndOrderPlacementPage.DeliveryAddressNameIsCorrect(), "First name or Last name are not correct");
            Assert.IsTrue(Pages.VerificationAndOrderPlacementPage.DeliveryAddressStreetIsCorrect(), "Street name or number are not correct");
        }

        [Then(@"Payment type is correct")]
        public void ThenPaymentTypeIsCorrect()
        {
            Assert.IsTrue(Pages.VerificationAndOrderPlacementPage.PaymentTypeIsCorrect(), "Payment type is not correct");
        }

        [Then(@"Amount is correct")]
        public void ThenAmountIsCorrect()
        {
            Assert.IsTrue(Pages.VerificationAndOrderPlacementPage.AmountIsCorrect(), "Amount is not correct");
        }

    }
}
