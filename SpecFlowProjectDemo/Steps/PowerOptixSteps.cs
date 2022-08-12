using OpenQA.Selenium;
using SpecFlowProjectDemo.Pages;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.PageObjects;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow.Assist;
using System.IO;
using System.Reflection;
using SpecFlowProjectDemo.Utilities;

namespace SpecFlowProjectDemo.Steps
{
    [Binding]
    public class PowerOptixSteps
    {
        public IWebDriver _webDriver;
        PowerOptixHomePage POHPage = null;
        BrowserLoginPage loginPage = null;


        public PowerOptixSteps()
        {
            _webDriver = (IWebDriver)Capabilities.driver;
            loginPage = new BrowserLoginPage();
            POHPage = new PowerOptixHomePage();

        }
        
        [Given(@"open browser")]
        public void GivenOpenBrowser()
        {
            _webDriver.Navigate().GoToUrl("https://demodev.kualitee.com");
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            
        }

        [When(@"user enter username  and password")]
        public void WhenUserEnterUsernameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            loginPage.enterUsername((string)data.Username); //(string)data.Username
            loginPage.enterPassword((string)data.Password); //(string)data.Password
        }

        [Then(@"click on sign In button")]
        public void WhenClickOnSignInButton()
        {
            
            loginPage.clickOnSignInBtn();
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
        }
        
        [Then(@"user click on XM link and AESO link")]
        public void WhenUserClickOnXMLinkAndAESOLink()
        {
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            POHPage.clickOnXM();
            POHPage.clickOnASEO();
        }
        
        [Then(@"verify user login successfully")]
        public void ThenVerifyUserLoginSuccessfully()
        {
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            loginPage.verifyUserSuccessfuulyLogin();
        }
        
        [Then(@"click on transaction")]
        public void ThenClickOnTransaction()
        {
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            POHPage.clickOntransaction();
        }
        
        [Then(@"click on operation link")]
        public void ThenClickOnOperationLink()
        {
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            POHPage.clickOnOperation();
        }
        
        [Then(@"click on As Availability link")]
        public void ThenClickOnAsAvailabilityLink()
        {
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            POHPage.clickOnAsAvailability();
        }
        
        [Then(@"verify Add,Delete,Save,Undo and export is displayed on screen")]
        public void ThenVerifyAddDeleteSaveUndoAndExportIsDisplayedOnScreen()
        {
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            POHPage.verifyAddBtnIsDisplayed();
            POHPage.verifyDeleteBtnIsDisplayed();
            POHPage.verifyExportBtnIsDisplayed();
            POHPage.verifySaveBtnIsDisplayed();
            POHPage.verifyUndoBtnIsDisplayed();
        }
        
        [Then(@"click on Add Button")]
        public void ThenClickOnAddButton()
        {
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            POHPage.clickOnAddBtn();
        }
        
        [Then(@"click on transcation")]
        public void ThenClickOnTranscation()
        {
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            POHPage.clickOntransaction();
        }
        
        [Then(@"click on operation and unit contraints")]
        public void ThenClickOnOperationAndUnitContraints()
        {
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            POHPage.clickOnOperation();
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            POHPage.clickOnUnitContraints();
        }
        
        [Then(@"click on show effective button")]
        public void ThenClickOnShowEffectiveButton()
        {
            _webDriver.SwitchTo().Alert().Accept();
            _webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(120);
            POHPage.clickOnShowEffective();
        }

        
    }
}