using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium.Service;
using System.Collections.Generic;
using System.IO;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Edge;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProjectDemo.Utilities
{
    static class Capabilities
    {
        static public Object driver { get; set; }
        static private AppiumLocalService appiumLocalService = null;
        static private string dir = Directory.GetParent(Directory.GetCurrentDirectory()).ToString();
        static private string configFile = dir + "/Capabilities/config.json";
        static private List<AppiumLocalService> appiumLocalServices= new List<AppiumLocalService>();
        public static void setUp(string environment)
        {
            try
            {
                switch (environment.ToLower())
                {
                    case "android":
                        openAndroidDriver();
                        break;
                    case "ios":
                        openIOSDriver();
                        break;
                    case "windows":
                        openWindowsDriver();
                        break;
                    case "browser":
                        openNativeBrowser();
                        break;
                    default:
                        driver = null;
                        Console.WriteLine("No driver found in switch method from json file");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Source: " + e.Source);
                Console.WriteLine("Message: " + e.Message);
                Console.WriteLine("Cause: " + e.InnerException);
                Console.WriteLine("Stack Trace: " + e.StackTrace.ToString());
            }
        }

        private static void openAndroidDriver()
        {
            Console.WriteLine("Starting Android Appium Service");
            AppiumLocalService appiumLocalService = startAppium();
            var options = readCapabilities(dir + "/Capabilities/androidCapabilities.json");
            driver = new AndroidDriver<AndroidElement>(appiumLocalService.ServiceUrl, options);
            Console.WriteLine("Appium Started");
            Console.WriteLine("Android Driver: "+driver);
        }

        private static void openIOSDriver()
        {
            Console.WriteLine("Starting IOS Appium Service");
            AppiumLocalService seappiumLocalService = startAppium();
            var options = readCapabilities(dir + "/Capabilities/iOSCapabilities.json");
            driver = new IOSDriver<IOSElement>(appiumLocalService.ServiceUrl, options);
            Console.WriteLine("Appium Started");
            Console.WriteLine("IOS Driver: "+driver);
        }

        private static void openWindowsDriver()
        {
            Console.WriteLine("Starting Windows Appium Service");
            AppiumLocalService seappiumLocalService = startAppium();
            var options = readCapabilities(dir + "/Capabilities/windowsCapabilities.json");
            driver = new WindowsDriver<WindowsElement>(appiumLocalService.ServiceUrl, options);
            Console.WriteLine("Appium Started");
            Console.WriteLine("Wubdows Driver: "+driver);
        }

        private static void openNativeBrowser(){
            Console.WriteLine("Starting Browser Driver Service");
            var browserName = getBrowserName(dir + "/Capabilities/browserConfig.json");
            switch(browserName.ToLower()){
                case "chrome":
                    setupChromeBrowser();
                    break;
                case "firefox":
                    setupFirefoxBrowser();
                    break;
                case "opera":
                    setupOperaBrowser();
                    break;
                case "edge":
                    setupEdgeBrowser();
                    break;
            }
            Console.WriteLine("Initiated Browser Driver: "+driver);
        }

        private static void setupChromeBrowser(){
            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
        }

        private static void setupFirefoxBrowser(){
            new DriverManager().SetUpDriver(new FirefoxConfig());
            driver = new FirefoxDriver();
        }

        private static void setupOperaBrowser(){
            new DriverManager().SetUpDriver(new OperaConfig());
            driver = new OperaDriver();
        }

        private static void setupEdgeBrowser(){
            new DriverManager().SetUpDriver(new EdgeConfig());
            driver = new EdgeDriver();
        }

        private static AppiumLocalService startAppium(){
            var builder = new AppiumServiceBuilder();
            appiumLocalService = builder.UsingAnyFreePort().Build();
            Console.WriteLine("Service URL: "+appiumLocalService.ServiceUrl);
            if (!appiumLocalService.IsRunning){
                Console.WriteLine("Appium Service Not Running");
                appiumLocalService.Start();
                Console.WriteLine("Appium Service Started");
            }
            Console.WriteLine("Appium Service: "+appiumLocalService);
            appiumLocalServices.Add(appiumLocalService);
            return appiumLocalService;
        }

        private static AppiumOptions readCapabilities(string path){
            Dictionary<string, object> json_Dictionary = jSonReader.getAllValues(path);
            var options = new AppiumOptions();
            Console.WriteLine("Android Capabilities: ");
            foreach (var item in json_Dictionary)
            {
                options.AddAdditionalCapability(item.Key, item.Value);
                Console.WriteLine(item.Key + " : " + item.Value);
            }
            return options;
        }

        private static string getBrowserName(string filePath){
            return jSonReader.getValue(filePath,"browser");
        }



        public static void stopAppium()
        {
            foreach(var item in appiumLocalServices){
                item.Dispose();
            }
        }

        public static void stopBrowserDriver(){
            var browserName = getBrowserName(dir + "/Capabilities/browserConfig.json");
            switch(browserName.ToLower()){
                case "chrome":
                    var chromeDriver = (ChromeDriver)driver;
                    chromeDriver.Quit();
                    break;
                case "firefox":
                    var foreFoxDriver = (FirefoxDriver)driver;
                    foreFoxDriver.Quit();
                    break;
                case "opera":
                    var operaDriver = (OperaDriver)driver;
                    operaDriver.Quit();
                    break;
                case "edge":
                    var edgeDriver = (EdgeDriver)driver;
                    edgeDriver.Quit();
                    break;
            }
        }
    }
}