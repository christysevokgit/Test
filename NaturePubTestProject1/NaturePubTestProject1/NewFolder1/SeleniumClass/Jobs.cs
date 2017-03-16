using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ValtechProject1.SeleniumClassSteps.Jobs

{
    class ValtechJobs_Selenium

    {
        private IWebDriver driver;
        public IWebElement IwebElement { get; set; }

        public ValtechJobs_Selenium(IWebDriver driver)

        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        /// <summary>
        /// This will assert Careers Text is present in the H1 tag after navigation
        /// </summary>
        public void AssertCareers_NameExists()
        {
            Assert.AreEqual("Careers", driver.FindElement(By.XPath("//h1[contains(.,'Careers')]")).Text);

        }
    }
}
