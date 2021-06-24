using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using SpecFlowProjectDemo.Utilities;

namespace SpecFlowProjectDemo.Pages
{
    class PowerOptixHomePage
    {
        public IWebDriver driver { get; }

        public PowerOptixHomePage()
        {
            this.driver = (IWebDriver)Capabilities.driver;
        }

        public IWebElement XMlink => driver.FindElement(By.XPath("//span[text()='XM']"));

        public IWebElement AESOlink => driver.FindElement(By.XPath("//span[text()='AESO']"));

        public IWebElement Transactionlink => driver.FindElement(By.XPath("//span[text()='Transactions']"));

        public IWebElement Operation => driver.FindElement(By.XPath("//span[text()='Operations']"));

        public IWebElement AsAvailability => driver.FindElement(By.XPath("//span[text()='AS Availability']"));

        public IWebElement AddBtn => driver.FindElement(By.XPath("//span[text()='Add']"));

        public IWebElement DeleteBtn => driver.FindElement(By.XPath("//span[text()='Delete']"));

        public IWebElement SaveBtn => driver.FindElement(By.XPath("//span[text()='Save']"));

        public IWebElement UndoBtn => driver.FindElement(By.XPath("//span[text()='Undo']"));

        public IWebElement ExportBtn => driver.FindElement(By.XPath("//span[text()='Export']"));

        public IWebElement UnitContraints => driver.FindElement(By.XPath("//span[text()='Unit Constraints']"));


        public IWebElement showEffectiveBtn => driver.FindElement(By.XPath("//span[contains(text(),'Show Effective:')]"));


        public void clickOnXM()
        {
            XMlink.Click();
            Console.WriteLine("Click on VM Link");
            
        }

        public void clickOnASEO()
        {
            AESOlink.Click();
            Console.WriteLine("Click on AESO Link");
        }

        public void clickOntransaction()
        {
           
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].click();", Transactionlink);
           // Actions action = new Actions(driver);
           // action.MoveToElement(Transactionlink);
           // Transactionlink.Click();
            Console.WriteLine("Click on Transaction Link");
        }

        public void clickOnOperation()
        {
            Operation.Click();
            Console.WriteLine("Click on Operation Link");
        }

        public void clickOnAsAvailability()
        {
            AsAvailability.Click();
            Console.WriteLine("Click on As availability Link");
        }

        public void verifyAddBtnIsDisplayed()
        {
            Assert.IsTrue(AddBtn.Displayed);
        }

        public void verifyDeleteBtnIsDisplayed()
        {
            Assert.IsTrue(DeleteBtn.Displayed);
        }

        public void verifySaveBtnIsDisplayed()
        {
            Assert.IsTrue(SaveBtn.Displayed);
        }

        public void verifyUndoBtnIsDisplayed()
        {
            Assert.IsTrue(UndoBtn.Displayed);
        }

        public void verifyExportBtnIsDisplayed()
        {
            Assert.IsTrue(ExportBtn.Displayed);
        }

        public void clickOnAddBtn()
        {
            AddBtn.Click();
            Console.WriteLine("Click on Add button");
        }

        public void clickOnUnitContraints()
        {
            UnitContraints.Click();
            Console.WriteLine("Click on unit constraints");
        }

        public void clickOnShowEffective()
        {
            showEffectiveBtn.Click();
            Console.WriteLine("Click on Show Effective Btn");
        }
    }
}