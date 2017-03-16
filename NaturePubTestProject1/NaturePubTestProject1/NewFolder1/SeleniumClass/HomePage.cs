using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace ValtechProject1.SeleniumClassSteps.HomePage

{
    class ValtechHomePage_Selenium

    {
        static void Main(string[] args)
        {
        }

        private IWebDriver driver;
        public IWebElement IwebElement { get; set; }

        public ValtechHomePage_Selenium(IWebDriver driver)

        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        /// <summary>
        /// This will assert that Latest News Heading is present
        /// </summary>
        public void AssertLatestNews(string Value)
        {                      
            driver.FindElement(By.XPath("//*[@id=\"container\"]")).GetAttribute("value");
        }

        /// <summary>
        /// This will click on Careers
        /// </summary>
        public void ClickCareers()
        {         
            driver.FindElement(By.XPath("//span[contains(.,'Careers')]")).Click();
        }

        /// <summary>
        /// This will click on Services 
        /// </summary>
        public void ClickServices()
        {        
            driver.FindElement(By.XPath("//span[contains(.,'Services')]")).Click();
        }

        /// <summary>
        /// This will click on Work (cases) link
        /// </summary>
        public void ClickWork()
        {       
            driver.FindElement(By.XPath("//span[contains(.,'Work')]")).Click();
        }


        /// <summary>
        /// This will click on Contact link
        /// </summary>
        public void ClickContact()
        {
            driver.FindElement(By.XPath("//i[@data-icon='earth-contact']")).Click();
        }















    }

}



