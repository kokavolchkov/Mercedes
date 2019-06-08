using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WireAutomation.Helpers;

namespace Automation.Scenarios.CollectionAndAccessories
{
    [Binding]
    public class CollectionAndAccessoriesSteps : BaseStep
    {

        [Given(@"User clicks the item number (.*) item from products")]
        public void GivenUserCliksTheItemNumberOneItemFromProducts(string number)
        {
            var productNumber = DataHelper.WordToInt(number);
            Pages.CollectionAndAccessoriesPage.ClickProduct(productNumber);
        }

        [Given(@"User clicks the Add to basket button")]
        public void GivenUserClicksTheAddToBasketButton()
        {
            Pages.CollectionAndAccessoriesPage.AddToBasketButtonClick();
            Pages.HomePage.WaitForSpinnerToDisappear();
        }

        [Given(@"User clicks the Continue Shopping button")]
        public void GivenUserClicksTheContinueShoppingButton()
        {
            Pages.CollectionAndAccessoriesPage.ContinueShoppingButtonClick();
            Pages.HomePage.WaitForSpinnerToDisappear();
        }

        [When(@"User clicks the Go to shopping basket button")]
        public void GivenUserClicksTheGoToShoppingBasketButton()
        {
            Pages.CollectionAndAccessoriesPage.GoToShoppingBasketButtonClick();
            Pages.HomePage.WaitForSpinnerToDisappear();
        }
        
        [Given(@"user clicks browser back button")]
        public void GivenUserClicksBrowserBackButton()
        {
            Pages.HomePage.BrowserNavigateBack();
        }
    }
}
