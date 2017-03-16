using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valtech.Test
{

    class HomePage_Selenium

    {
        static void Main(string[] args)
        {
        }

        private IWebDriver driver;
        public IWebElement IwebElement { get; set; }

        public HomePage_Selenium(IWebDriver driver)

        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        /// <summary>
        /// This will assert nature website search home page
        /// </summary>
        public void AssertHomePage()
        {
            Assert.IsTrue(driver.FindElement(By.XPath("//a[@id='logo']")).Displayed);

        }






    }
}
