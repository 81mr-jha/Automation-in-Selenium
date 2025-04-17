using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerceTesting.Setup;
using eCommerceTesting.TestMethods;
using eCommerceTesting.TestData;

namespace eCommerceTesting.TestSuite
{
    public class SmokeTest : LoginTestMethods 
    {
        TestCreds creds ;

        [Test, Order(1)]
        public void RegisterUser()
        {
            LaunchURL();
            CheckHomePageVisibleOrNot();
            ClickSignupAndLoginButton();
            VerifyNewUserSignUPHeading();
            EnterNameAndEmail("Mayank", "mayank342@gmail.com");
            ClickSignUpButton();
            VerifyAccountInformation();
            creds = new TestCreds(driver);
            creds.EnterAccountInformation();
            ClickOnContinueButton();
            VerifyAccountCreation();
            DeleteAccount();
            ClickOnContinueButton();
        }

    }
}
