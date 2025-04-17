using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerceTesting.Reusable;
using OpenQA.Selenium;

namespace eCommerceTesting.TestData
{
    public class TestCreds : Selectors
    {
        public TestCreds(IWebDriver driver) : base(driver) { }

        public const string Name = "ABC Singh";
        public const string Email = "abcsingh@gmail.com";
        public const string PasswordText = "Password";
        public const string Firstname = "Mukul";
        public const string Lastname = "Sharma";
        public const string AddressText = "c/234 Mumbai";
        public const string StateText = "Maharastra";
        public const string CityText = "Mumbai";
        public const string ZipcodeText = "783939";
        public const string MobileNumberText = "7983488934";

        public void EnterAccountInformation()
        {
            Password.SendKeys(PasswordText);

            //SelectElement DayDropdown = new SelectElement(SelectDays);
            //DayDropdown.SelectByValue("15");

            //SelectElement MonthDropdown = new SelectElement(SelectDays);
            //MonthDropdown.SelectByValue("October");

            //SelectElement YearDropdown = new SelectElement(SelectDays);
            //YearDropdown.SelectByValue("2002");

            new SelectElement(SelectDays).SelectByValue("15");
            new SelectElement(SelectMonths).SelectByText("October");
            new SelectElement(SelectYears).SelectByValue("2002");

            FirstName.SendKeys(Firstname);
            LastName.SendKeys(Lastname);
            Address.SendKeys(AddressText);
            State.SendKeys(StateText);
            City.SendKeys(CityText);
            Zipcode.SendKeys(ZipcodeText);
            MobileNumber.SendKeys(MobileNumberText);

            CreateAccountButton.Click();

        }


    }
}
