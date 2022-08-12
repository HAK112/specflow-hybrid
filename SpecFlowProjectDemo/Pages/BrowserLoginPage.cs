﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using SpecFlowProjectDemo.Utilities;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProjectDemo.Pages
{
    class BrowserLoginPage
    {
        private IWebDriver driver { get; }

        public BrowserLoginPage()
        {
            this.driver = (IWebDriver)Capabilities.driver;
        }

        public IWebElement username => driver.FindElement(By.XPath("//input[@id='email_id']"));

        public IWebElement password => driver.FindElement(By.XPath("//input[@id='password']"));

        public IWebElement signinBtn => driver.FindElement(By.XPath("//input[@value='Let Me In']"));

        public IWebElement homeTitle => driver.FindElement(By.XPath("//a[text()='Dashboard Activities']"));

        
      

        public void enterUsername(String un)
        {
            username.SendKeys(un);
        }

        public void enterPassword(String pwd)
        {
            password.SendKeys(pwd);
        }

        public void clickOnSignInBtn()
        {
            signinBtn.Click();
        }

        public void verifyUserSuccessfuulyLogin()
        {

            Assert.IsTrue(homeTitle.Displayed);
        }


    }
}
