using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automation.Helpers;
using Automation.Pages;
using TechTalk.SpecFlow;

namespace Automation.PageObjects
{
    public class CollectionAndAccessoriesPage : BasePage
    {
        public CollectionAndAccessoriesPage(IWebDriver driver) : base(driver)
        {
        }

        #region Locators
        public List <IWebElement> ProductsList
        {
            get { return WebDriver.FindElementsByCssSelector(".utils-product-tile-image-inner"); }
        }

        public IWebElement ProductName
        {
            get { return WebDriver.FindElementByCssSelector(".dcp-ar2.ng-binding"); }
        }

        public IWebElement ProductPrice
        {
            get { return WebDriver.FindElementByCssSelector("[itemprop='price']"); }
        }

        public IWebElement AddToBasketButton
        {
            get { return WebDriver.FindElementByCssSelector("[data-ng-click = 'addToCart(product)']"); }
        }

        public IWebElement ContinueShoppingButton
        {
            get { return WebDriver.FindElementByCssSelector(".wb-e-btn-4.dcp-modal__cta.ng-binding"); }
        }

        public IWebElement GoToShoppingBasketButton
        {
            get { return WebDriver.FindElementByCssSelector(".col-xs-12 [data-track-click-as = 'open cart']"); }
        }

        #endregion

        /// <summary>
        /// Click the product specified by number in a list
        /// </summary>
        /// <param name="number"></param>
        public void ClickProduct(int number)
        {
            ProductsList.ElementAt(number - 1).Click();
            ScenarioContext.Current["ProductName"] = ProductName.Text;
            ScenarioContext.Current["ProductPrice"] = ProductPrice.GetAttribute("content").TrimStart('£').ToString();
            ScenarioContext.Current["ProductQuantity"] = ProductPrice.GetAttribute("content").ToString();
        }

        /// <summary>
        /// Click the Add to basket button
        /// </summary>
        public void AddToBasketButtonClick()
        {
            AddToBasketButton.Click();
        }

        /// <summary>
        /// Click the Continue shopping button
        /// </summary>
        public void ContinueShoppingButtonClick()
        {
            ContinueShoppingButton.Click();
        }

        /// <summary>
        /// Click the Go to shopping basket button
        /// </summary>
        public void GoToShoppingBasketButtonClick()
        {
            GoToShoppingBasketButton.Click();
        }
    }
}
