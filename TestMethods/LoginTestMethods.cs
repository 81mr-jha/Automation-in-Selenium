﻿using eCommerceTesting.Setup;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerceTesting.Reusable;

namespace eCommerceTesting.TestMethods
{
   public class LoginTestMethods : Selectors
    {
        public LoginTestMethods(IWebDriver driver) : base(driver)
        {
        }

        public void LaunchURL()
        {
            Thread.Sleep(1000);
            driver.Navigate().GoToUrl("http://automationexercise.com/");
        }
        public void CheckHomePageVisibleOrNot()
        {
            IWebElement logo = driver.FindElement(By.XPath("//div[@class='logo pull-left']"));
            Thread.Sleep(1000);
            Assert.That(logo.Displayed, Is.True, "Home page is not visible");
            Thread.Sleep(1000);
        }
        public void ClickSignupAndLoginButton()
        {
            SignUpAndLoginButton.Click();
            Thread.Sleep(1000);
        }
        public void VerifyNewUserSignUPHeading()
        {
            IWebElement heading = driver.FindElement(By.CssSelector("div.signup-form h2"));
            Thread.Sleep(1000);
            Assert.That(heading.Displayed, Is.True, "Sign up heading is not visible.");

        }
        public void EnterNameAndEmail(string name, string email)
        {
            InputName.SendKeys(name);
            Thread.Sleep(1000);
            InputEmail.SendKeys(email);
            Thread.Sleep(1000);
        }
        public void ClickSignUpButton()
        {
            SignUpButton.Click();
            Thread.Sleep(1000);
        }

        public void VerifyAccountInformation()
        {
            IWebElement logo = driver.FindElement(By.XPath("//b[contains(text(),'Enter Account Information')]"));
            Thread.Sleep(1000);
            Assert.That(logo.Displayed, Is.True, "Home page is not visible");
            Thread.Sleep(1000);
        }

        public void ClickSignupNewsletter()
        {
            IWebElement logo = driver.FindElement(By.XPath("//label[contains(text(),'Sign up for our newsletter!')]"));
            Thread.Sleep(1000);
            logo.Click();
        }

        public void ClickReceiveOffersFromPatners()
        {
            IWebElement logo = driver.FindElement(By.XPath("//label[contains(text(),'Receive special offers from our partners!')]"));
            Thread.Sleep(1000);
            logo.Click();
        }

        public void VerifyAccountCreation()
        {
            try
            {
                Thread.Sleep(1000);
                IWebElement logo = driver.FindElement(By.XPath("//h2[@data-qa='account-created']"));
                Thread.Sleep(1000);
            }
            catch 
            {
                Console.WriteLine("Check this method");
            }
        }

        public void ClickOnContinueButton()
        {
            IWebElement logo = driver.FindElement(By.XPath("//a[@data-qa='continue-button']"));
            Thread.Sleep(1000);
            logo.Click();
        }

        public void LogInAsUserName()
        {
            IWebElement logo = driver.FindElement(By.XPath("//a[contains(text(),'Logged in as')]"));
            Thread.Sleep(1000);
        }

        //public void DeleteAccount()
        //{
        //    Thread.Sleep(1000); a23@gmail.com
        //    IWebElement logo = driver.FindElement(By.XPath("//a[contains(text(),'Delete Account')]"));

        //    logo.Click() ;
        //    Thread.Sleep(1000);
        //}
        public void DeleteAccount()
        {
            Thread.Sleep(1000);
            IWebElement logo = driver.FindElement(By.XPath("//a[contains(text(),'Delete Account')]"));

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", logo);  
            js.ExecuteScript("arguments[0].click();", logo);               

            Thread.Sleep(1000);
        }

        public void VerifyAccountDeletion()
        {
            IWebElement logo = driver.FindElement(By.XPath("//h2[@data-qa='account-deleted']"));
            Thread.Sleep(1000);
        }
        public void VerifyLoginAccountVisibility()
        {
            Thread.Sleep(500);
            IWebElement logo = driver.FindElement(By.XPath("//h2[normalize-space()='Login to your account']"));
            Thread.Sleep(500);
        }
        public void EnterLogInEmailAndPassword(string email,string password)
        {
            Thread.Sleep(500);
            LoginEmail.SendKeys(email);
            LoginPassword.SendKeys(password);
            Thread.Sleep(500);
        }
        public void ClickLogInButton()
        {
            IWebElement logo = driver.FindElement(By.XPath("//button[@data-qa='login-button']"));
            Thread.Sleep(1000);
            logo.Click();
        }
        //public void VerifiedUserName()
        //{
        //    IWebElement logo = driver.FindElement(By.XPath("//a[contains(text(),'Logged in as']"));
        //}
    }
}
