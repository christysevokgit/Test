using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ValtechProject1.SeleniumClassSteps.Work
{
    class ValtechWorkCases_Selenium

    {
        private IWebDriver driver;
        public IWebElement IwebElement { get; set; }

        public ValtechWorkCases_Selenium(IWebDriver driver)

        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        /// <summary>
        /// This will assert Work Text is present in the H1 tag after navigation
        /// </summary>
        public void AssertWork_CasesNameExists()
        {
            Assert.AreEqual("Work", driver.FindElement(By.XPath("//h1[contains(.,'Work')]")).Text);
        }

    }
}

