using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace ValtechProject1.SeleniumClassSteps.Services
{
    class ValtechServices_Selenium

    {
        private IWebDriver driver;
        public IWebElement IwebElement { get; set; }

        public ValtechServices_Selenium(IWebDriver driver)

        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }



        /// <summary>
        /// This will assert Services Text is present in the H1 tag after navigation
        /// </summary>
        public void AssertServices_NameExists()
        {
            Assert.AreEqual("Services", driver.FindElement(By.XPath("//h1[contains(.,'Services')]")).Text);
        }

    }
    }
