using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniumtest
{
    class HomePage
    {

        IWebDriver driver;
        private IWebElement regForm;

        public HomePage(IWebDriver _driver)
        {
            driver = _driver;
            
        }


        [FindsBy(How = How.ClassName, Using = "login")]
        public IWebElement registrationPage { get; set; }


        public IWebElement getRegForm()
        {
            regForm = driver.FindElement(By.ClassName("login"));
            return regForm;
        }







    }
}
