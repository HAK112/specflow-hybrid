using OpenQA.Selenium.Appium;
using SpecFlowProjectDemo.Pages;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using SpecFlowProjectDemo.Utilities;

namespace SpecFlowProjectDemo.Steps
{
    [Binding]
    public class GuestModuleSteps
    {
        public AppiumDriver<AppiumWebElement> driver;
        LoginPage loginPage = null;


        public GuestModuleSteps()
        {
            // driver = Capabilities.driver;
            loginPage = new LoginPage();
            Console.WriteLine("Driver: "+driver);
        }

        [Then(@"user clicks on continue as guest")]
        public void ThenUserClickOnContinueAsGuest()
        {
            loginPage.clickguest();
        }   

        [Then(@"user clicks on coronavirus")]
        public void ThenUserClicksOnCoronaVirus()
        {
            loginPage.clickCorona();
        }   

        [Then(@"user clicks on material")]
        public void ThenUserClicksOnMaterial()
        {
            loginPage.clickMaterial();
        }     
    }
}
