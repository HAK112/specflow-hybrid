using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using SpecFlowProjectDemo.Utilities;

namespace SpecFlowProjectDemo.Pages
{
    class LoginPage
    {
        private AndroidDriver<AndroidElement> driver { get; }

        public AndroidElement usernameInputField => driver.FindElementByXPath("//android.widget.EditText[contains(@text,'username')]");
		
        public AndroidElement passwordInputField => driver.FindElementByXPath("//android.widget.EditText[contains(@text,'password')]");
	   
        public AndroidElement signInButton => driver.FindElementById("ae.gov.dha.flagship:id/login_button");
	
        public AndroidElement skipButton => driver.FindElementByXPath("//android.widget.TextView[@text='CONTINUE AS A GUEST']");

        public AndroidElement coronafield => driver.FindElementByXPath("//android.widget.TextView[contains(@text,'CORONAVIRUS')]");

        public AndroidElement material => driver.FindElementByXPath("//android.widget.TextView[contains(@text,'Material')]");

        public LoginPage()
        {
            this.driver = (AndroidDriver<AndroidElement>)Capabilities.driver;
            Console.WriteLine("Login Page Driver: "+this.driver);
            this.driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

       public void clickSignIn() {
		    signInButton.Click();
	    }
	    public void clickguest() {
            skipButton.Click();
	    }
	    public void clickCorona() {
		    coronafield.Click();
	    }
	    public void clickMaterial() {
		    material.Click();
		    driver.Navigate().Back();
	    }
	
	    public void sendUsername(String username) {
		    usernameInputField.SendKeys(username);
	    }
	
	    public void sendPassword(String password) {
		    passwordInputField.SendKeys(password);
	    }	
    }
}
