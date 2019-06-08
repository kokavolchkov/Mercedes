using Automation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace WireAutomation.Scenarios.ShoppingBasket
{
    [Binding]
    public class ShoppingBasketSteps : BaseStep
    {

        [Then(@"Product name is correct")]
        public void ThenProductNameIsCorrect()
        {
            Assert.IsTrue(Pages.ShoppingBasketPage.ProductNameIsCorrect(), "Product name is not correct");
        }

        [Then(@"Product price is correct")]
        public void ThenProductPriceIsCorrect()
        {
            Assert.IsTrue(Pages.ShoppingBasketPage.ProductPriceIsCorrect(), "Product price is not correct");
        }

        [When(@"User clicks the Continue to address and delivery button")]
        public void WhenUserClicksTheContinueToAddressAndDeliveryButton()
        {
            Pages.ShoppingBasketPage.ContinueToAddressAndDeliveryButtonClick();
        }
    }
}
