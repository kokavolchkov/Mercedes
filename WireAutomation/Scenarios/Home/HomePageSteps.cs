using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Automation.Scenarios
{
    [Binding]
    public class HomePageSteps : BaseStep
    {
        [Given(@"User opened Home page")]
        public void GivenUserOpenedHomePage()
        {
            Pages.HomePage.OpenHomePage();
            Pages.HomePage.WaitForSpinner();
        }

        [Given(@"User closes cookies pop-up")]
        public void GivenUserClosesCookiesPop_Up()
        {
            Pages.HomePage.CloseCookiesButtonClick();
        }

        [Given(@"User clicks the Collection and Accessories link")]
        public void WhenUserClickTheSupportPageLink()
        {
            Pages.HomePage.OpenCollectionAndAccessoriesPage();
        }

        [Given(@"User clicks the All Products button")]
        public void GivenUserClicksTheAllProductsButton()
        {
            Pages.HomePage.AllProductsClick();
            Pages.HomePage.WaitForSpinnerToDisappear();
        }

        [Given(@"User clicks See All Products button")]
        public void GivenUserClicksSeeAllProductsButton()
        {
            Pages.HomePage.SeeAllProductsButtonClick();
            Pages.HomePage.WaitForSpinnerToDisappear();
        }
    }
}
