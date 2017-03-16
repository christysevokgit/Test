using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ValtechProject1.SeleniumClassSteps.HomePage;
using ValtechProject1.SeleniumClassSteps.Jobs;
using ValtechProject1.SeleniumClassSteps.Services;
using ValtechProject1.SeleniumClassSteps.Work;
using ValtechProject1.SeleniumClassSteps.Contact;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace ValtechTestProject1
{
    [TestClass]
    public class ValtechTest
    {
        public IWebDriver driver;
        public IWebElement IwebElement { get; set; }
        public IWebDriver WebDriverInstance { get; private set; }
        public string baseURL;

        /// <summary>
        /// Initializes the browser and url
        /// </summary>
        [TestInitialize]
        public void Initialize_Selenium()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.valtech.com/";
        }

        /// <summary>
        /// This tests Navigates to www.valtech.com homepage and then asserts latest news section is displying.
        /// Then navigates to cases, services and jobs pages and asserts that H1 tags are displaying correctly for each one of them.
        /// Then Navigates to the Contact page and outputs how many Valtech offices are there in total
        /// </summary>
        [TestMethod]
        [TestCategory("Valtech /Homepage/Test")]
        public void ValtechTests()
        {
            driver.Navigate().GoToUrl(baseURL);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            ValtechHomePage_Selenium HomePage = new ValtechHomePage_Selenium(driver);
            HomePage.AssertLatestNews("LATEST NEWS");
            HomePage.ClickCareers();

            ValtechJobs_Selenium Jobs = new ValtechJobs_Selenium(driver);
            Jobs.AssertCareers_NameExists();

            HomePage.ClickServices();

            ValtechServices_Selenium Services = new ValtechServices_Selenium(driver);
            Services.AssertServices_NameExists();

            HomePage.ClickWork();

            ValtechWorkCases_Selenium Work = new ValtechWorkCases_Selenium(driver);
            Work.AssertWork_CasesNameExists();

            HomePage.ClickContact();

            ValtechContact_Selenium Contact = new ValtechContact_Selenium(driver);
            Contact.CountTotaloffices();

            driver.Quit();
        }

   
    }
}

