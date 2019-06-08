using BoDi;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Automation
{
    /// <summary>
    /// InitializeScenario class
    /// Creates instance of the webdriver
    /// Registers webdriver instance that will be sent to the BaseStep class
    /// Closes browser
    /// </summary>
    /// 
    [Binding]
    public sealed class InitializeScenario
    {
        public IWebDriver _webDriver;
        public IObjectContainer _objectContainer;

        public InitializeScenario(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario]
        public void Initialize()
        {
            _webDriver = Driver.CreateDriver();
            _objectContainer.RegisterInstanceAs(new WebDriverContainer(_webDriver));
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _webDriver.Quit();
        }
    }
}
