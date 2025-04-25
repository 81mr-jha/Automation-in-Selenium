using eCommerceTesting.TestMethods;
using eCommerceTesting.TestData;
using OpenQA.Selenium.Chrome;

namespace eCommerceTesting.TestSuite
{

    [TestFixture]
    public class SmokeTest : LoginTestMethods
    {
        TestCreds creds;
        public static string email = "mayank2@gmail.com";
        public static string password = "P@ssw0rd";

        public SmokeTest() : base(null) { }

        [OneTimeSetUp]
        public void Init()
        {
            driver = new ChromeDriver();
            base.driver = driver;
            creds = new TestCreds(driver);
        }

        [Test, Order(1)]
        public void RegisterUser()
        {
            LaunchURL();
            CheckHomePageVisibleOrNot();
            ClickSignupAndLoginButton();
            VerifyNewUserSignUPHeading();
            EnterNameAndEmail("Mayank", email);
            ClickSignUpButton();
            VerifyAccountInformation();
            creds.EnterAccountInformation(password);
            ClickOnContinueButton();
            VerifyAccountCreation();
            DeleteAccount();
            ClickOnContinueButton();
        }

        [Test, Order(2)]
        public void LoginWithCorrectEmailAndPassword()
        {
            LaunchURL();
            CheckHomePageVisibleOrNot();
            ClickSignupAndLoginButton();
            VerifyLoginAccountVisibility();
            EnterLogInEmailAndPassword(email, password);
            ClickLogInButton();
            LogInAsUserName();
            DeleteAccount();
            ClickOnContinueButton();
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}

