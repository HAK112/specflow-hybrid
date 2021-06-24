using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using SpecFlowProjectDemo.Utilities;
using System;

namespace SpecFlowProjectDemo.Drivers
{
    [Binding]
    static class Driver
    {
        [AfterTestRun]
        public static void TearDown()
        {
            Capabilities.stopAppium();
            Capabilities.stopBrowserDriver();
        }
    }
}