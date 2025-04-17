using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerceTesting.Setup;
using OpenQA.Selenium;

namespace eCommerceTesting.Reusable
{
    public class Selectors
    {
        protected IWebDriver driver;

        public Selectors(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement SignUpAndLoginButton => driver.FindElement(By.CssSelector("a[href='/login']"));
        public IWebElement SignUpButton => driver.FindElement(By.CssSelector("button[data-qa='signup-button']"));
        public IWebElement InputName => driver.FindElement(By.CssSelector("input[data-qa='signup-name']"));
        public IWebElement InputEmail => driver.FindElement(By.CssSelector("input[data-qa='signup-email']"));
        public IWebElement Password => driver.FindElement(By.CssSelector("input[data-qa='password']"));
        public IWebElement SelectDays => driver.FindElement(By.XPath("//select[@data-qa='days']"));
        public IWebElement SelectMonths => driver.FindElement(By.XPath("//select[@data-qa='months']"));
        public IWebElement SelectYears => driver.FindElement(By.XPath("//select[@data-qa='years']"));
        public IWebElement FirstName => driver.FindElement(By.XPath("//input[@data-qa='first_name']"));
        public IWebElement LastName => driver.FindElement(By.XPath("//input[@data-qa='last_name']"));
        public IWebElement Address => driver.FindElement(By.XPath("//input[@data-qa='address']"));
        public IWebElement State => driver.FindElement(By.XPath("//input[@data-qa='state']"));
        public IWebElement City => driver.FindElement(By.XPath("//input[@data-qa='city']"));
        public IWebElement Zipcode => driver.FindElement(By.XPath("//input[@data-qa='zipcode']"));
        public IWebElement MobileNumber => driver.FindElement(By.XPath("//input[@data-qa='mobile_number']"));
        public IWebElement CreateAccountButton => driver.FindElement(By.XPath("//button[@data-qa='create-account']"));
        public IWebElement SelectTitle => driver.FindElement(By.Id("id_gender1"));

    }
}
