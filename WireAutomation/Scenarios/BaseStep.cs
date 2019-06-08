using BoDi;
using OpenQA.Selenium;
using Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Automation
{
    /// <summary>
    /// BaseStep class
    /// Receives the webdriver instance from the InitializeScenario class
    /// Creates PageCollection instance
    /// Sends webdriver to the PageCollection ctor
    /// </summary>
    public class BaseStep
    {
        protected PageCollection Pages { get; private set; }

        protected IWebDriver WebDriver;

        public BaseStep()
        {
            var objectContainer = (IObjectContainer)ScenarioContext.Current.GetBindingInstance(typeof(IObjectContainer));
            var driverContainer = objectContainer.Resolve<WebDriverContainer>();

            Pages = new PageCollection(driverContainer.WebDriver);
        }        
    }
}
