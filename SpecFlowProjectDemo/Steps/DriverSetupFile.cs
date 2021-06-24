using OpenQA.Selenium.Appium;
using SpecFlowProjectDemo.Pages;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using SpecFlowProjectDemo.Utilities;

namespace SpecFlowProjectDemo.Steps
{
    [Binding]
    public class DriverModuleSteps
    {
        public AppiumDriver<AppiumWebElement> driver;        
        
        [Given(@"the application is open")]
        public void GivenTheApplicationIsOpen(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            Capabilities.setUp(((string)data.application));
        }

        [When(@"the application is open")]
        public void WhenTheApplicationIsOpen(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            Capabilities.setUp(((string)data.application));
        }
    } 
}
