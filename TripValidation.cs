using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace Seleniumtest
{
    class TripValidation
    {
        private const string chromePath = @"D:\\3rdparty\\chrome";
        private const string website = "https://www.expedia.com/";
      
        IWebDriver driver;

        [SetUp]
                public void startBrowser()
        {
            driver = new ChromeDriver(chromePath);
            driver.Manage().Window.Maximize();
            driver.Url = website;
        }



        [Test]
        public void FlightSelection()
        {
            FlightSelection homePage = new FlightSelection(driver);
            IWebElement selectFlightsOption  = homePage.getFlights();
            selectFlightsOption.Click();
            IWebElement passengerTotal = homePage.getPassengerTotal();
            passengerTotal.Click();
            IWebElement addPassenger = homePage.getAddPassenger();
            addPassenger.Click();
            addPassenger.Click();
            addPassenger.Click();
         

            IWebElement submitPassenger = homePage.getSubmitPassengerList();
            submitPassenger.Click();          

            IWebElement multiFlightSelection = homePage.getMultiFlightSelection();
            multiFlightSelection.Click();
            IWebElement firstFlightSelection = homePage.getFirstFlightSelection();
            firstFlightSelection.Click();
            IWebElement FromDestination = homePage.getFromSelection();
            FromDestination.Click();

        }



        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }

  
}

