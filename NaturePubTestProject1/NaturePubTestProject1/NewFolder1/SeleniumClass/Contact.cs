using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;

namespace ValtechProject1.SeleniumClassSteps.Contact
{
    class ValtechContact_Selenium

    {
        private IWebDriver driver;
        public IWebElement IwebElement { get; set; }

        public ValtechContact_Selenium(IWebDriver driver)

        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        /// <summary>
        /// This method will count and output how many Valtech offices are there in total
        /// </summary>
        public void CountTotaloffices()
        {
           int numberofoffices = driver.FindElements(By.CssSelector("[class='contactcities'] li")).Count;
           Console.WriteLine(numberofoffices);
           
        }

    }
}
