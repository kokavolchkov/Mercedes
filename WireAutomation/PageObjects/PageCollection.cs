using OpenQA.Selenium;
using Automation.PageObjects;
using WireAutomation.PageObjects;

namespace Pages
{
    /// <summary>
    /// PageCollection class
    /// Agregates all webpages
    /// Returnes instance of webpage that is created
    /// </summary>
    public class PageCollection
    {
        private readonly IWebDriver _driver;
        public PageCollection(IWebDriver webDriver)
        {
            _driver = webDriver;
        }

        public HomePage HomePage
        {
            get { return new HomePage(_driver); }
        }

        public AddressDeliveryPage AddressDeliveryPage
        {
            get { return new AddressDeliveryPage(_driver); }
        }

        public PaymentTypePage PaymentTypePage
        {
            get { return new PaymentTypePage(_driver); }
        }

        public CollectionAndAccessoriesPage CollectionAndAccessoriesPage
        {
            get { return new CollectionAndAccessoriesPage(_driver); }
        }

        public ShoppingBasketPage ShoppingBasketPage
        {
            get { return new ShoppingBasketPage(_driver); }
        }

        public VerificationAndOrderPlacementPage VerificationAndOrderPlacementPage
        {
            get { return new VerificationAndOrderPlacementPage(_driver); }
        }
    }
}