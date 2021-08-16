using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seleniumtest
{
    class FlightSelection
    {
        private IWebDriver driver;
        private IWebElement selectFlight;
        private IWebElement selectPassengerTotal;
        private IWebElement selectAddPasenger;
        private IWebElement submitPasengerList;
        private IWebElement submitMultiFlight;
        private IWebElement selectFirstFlight;
        private IWebElement selectFirstFromFlight;
        public FlightSelection(IWebDriver _driver)
        {
            driver = _driver;


        }

        public IWebElement getFlights()
        {
            selectFlight = driver.FindElement(By.XPath("//*[@id='wizardMainRegionV2']/div/div/div[2]/div/div/ul/li[2]/a"));
            return selectFlight;
        }

         public IWebElement getPassengerTotal()
        {
            selectPassengerTotal = driver.FindElement(By.XPath("//*[@id='adaptive-menu']/a"));
            return selectPassengerTotal;
        }
        public IWebElement getAddPassenger()
        {
            selectAddPasenger = driver.FindElement(By.XPath("//*[@id='adaptive-menu']/div/div/section/div[1]/div[1]/div/button [2]"));
            return selectAddPasenger;
        }

        public IWebElement getSubmitPassengerList()
        {
            submitPasengerList = driver.FindElement(By.XPath("//*[@id='adaptive-menu']/div/div/div[2]/button"));
            return submitPasengerList;
        }

        public IWebElement getMultiFlightSelection()
        {
            submitMultiFlight = driver.FindElement(By.XPath("//*[@id='adaptive-menu']/div/div/div[2]/button"));
            return submitMultiFlight;
        }

        public IWebElement getFirstFlightSelection()
        {
            selectFirstFlight = driver.FindElement(By.XPath("//*[@id='location-field-leg" + 1 + "-origin-menu']/div[1]/button"));
            return selectFirstFlight;
        }

        public IWebElement getFromSelection()
        {
            selectFirstFromFlight = driver.FindElement(By.XPath("//*[@id='location-field-leg" + 1 + "-origin']"));
            return selectFirstFromFlight;
        }
      

    }
}
