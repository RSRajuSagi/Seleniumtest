using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniumtest
{
    class LoginPage
    {
        private IWebDriver driver;
        private IWebElement regEmail;
        private IWebElement regPassword;
        private IWebElement regSubmit;
        private IWebElement regValidationMessage;

        public LoginPage(IWebDriver _driver)
        {
            driver = _driver;


        }

        public IWebElement getRegEmail()
        {
            regEmail = driver.FindElement(By.Name("email"));
            return regEmail;
        }
        public IWebElement getRegPassword()
        {
            regPassword = driver.FindElement(By.Name("passwd"));
            return regPassword;
        }

        public IWebElement getRegSubmit()
        {
            regSubmit = driver.FindElement(By.Name("SubmitLogin"));
            return regSubmit;
        }

        public IWebElement regValidation()
        {
            regValidationMessage = driver.FindElement(By.XPath("//*[@id='center_column']/div[1]/ol/li"));
            return regValidationMessage;
        }


     

        public void PerformLogin(string userName, string password)
        {

            LoginPage loginPage = new LoginPage(driver);

            IWebElement regEmail = loginPage.getRegEmail();
            regEmail.SendKeys(userName);
         
            IWebElement regPassword = loginPage.getRegPassword();
            regPassword.SendKeys(password);

            IWebElement regSubmit = loginPage.getRegSubmit();
            regSubmit.Click();
                     
        }
    
    
    
    
    
    
    
    }
    
}
