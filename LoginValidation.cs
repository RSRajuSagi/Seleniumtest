using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;


namespace Seleniumtest
{
    class LoginValidation
    {
        private const string chromePath = @"D:\\3rdparty\\chrome";
        private const string website = "http://automationpractice.com";
        private const string expectedValidationEmailMessage = "An email address required.";
        private const string expectedValidationPasswordMessage = "Password is required.";
        private const string expectedValidationAuthenticationFailed = "Authentication failed.";
        IWebDriver driver;

        [SetUp]

        public void startBrowser()
        {
            driver = new ChromeDriver(chromePath);
            driver.Manage().Window.Maximize();
            driver.Url = website;
        }



        [Test]
        public void emptyEmailWithemptyPassword()
        {
           //Validate empty email with empty password 
            var actualMessage = validationLogin(string.Empty, string.Empty);
            Assert.AreEqual(actualMessage, expectedValidationEmailMessage);          

        }


        [Test]
        public void emptyEmailWithValidPassword()
        {
            //Validate empty email with valid password 
            var actualMessage = validationLogin(string.Empty, "1236");
            Assert.AreEqual(actualMessage, expectedValidationEmailMessage);         

        }

        [Test]
        public void validEmaiWithemptyPassword()
        {
            //Validate valid email with empty password 
            var actualMessage = validationLogin("abc@def.com", string.Empty);
            Assert.AreEqual(actualMessage, expectedValidationPasswordMessage);

        }

        [Test]
        public void invalidEmaiWithinvalidPassword()

        {
            //Validate with invalid email with invalid password 
            var actualMessage = validationLogin("abc@def.com", "123qwe");
            Assert.AreEqual(actualMessage, expectedValidationAuthenticationFailed);         

        }


        private string validationLogin(string email, string password)
        {

            //Login Validation 
            HomePage homePage = new HomePage(driver);
            IWebElement regForm = homePage.getRegForm();
            regForm.Click();
            Thread.Sleep(TimeSpan.FromSeconds(30));
            LoginPage loginPage = new LoginPage(driver);
            loginPage.PerformLogin(email, password);
            IWebElement regValidation = loginPage.regValidation();
            return regValidation.Text;

        }



        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

  

    }
}