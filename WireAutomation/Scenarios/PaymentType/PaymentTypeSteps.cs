using Automation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace WireAutomation.Scenarios.PaymentType
{
    [Binding]
    public class PaymentTypeSteps : BaseStep
    {
        [When(@"User sets Payment type to Credit Card")]
        public void WhenUserSetsPaymentTypeToCreditCard()
        {
            Pages.PaymentTypePage.PaymentTypeIsCreditCard();
        }

        [When(@"User sets the Credit Card type to MasterCard")]
        public void WhenUserSetsTheCreditCardTypeToMasterCard()
        {
            Pages.PaymentTypePage.CreditCardTypeIsMasterCard();
        }

        [When(@"User clicks the Continue to verification and order placement button")]
        public void WhenUserClicksTheContinueToVerificationAndOrderPlacementButton()
        {
            Pages.PaymentTypePage.ContinueToVerificationAndOrderPlacementButtonClick();
        }
    }
}
