using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NatureTestExercise;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Text;
using OpenQA.Selenium.Support.UI;
using NatureTestExercise.SeleniumTest_Class;

namespace NaturePubTestProject1
{
    [TestClass]
    public class NatureTest
    {
        public IWebDriver driver;
        public IWebElement IwebElement { get; set; }
        public IWebDriver WebDriverInstance { get; private set; }
      //  private bool acceptNextAlert = true;
        private StringBuilder verificationErrors;
        public string baseURL;


        [TestInitialize]
        public void Initialize_Selenium()

        {
            driver = new FirefoxDriver();

            //driver = new ChromeDriver(@"C:\Users\christy\Downloads\chromedriver_win32");          
            baseURL = "http://link.springer.com/";
            verificationErrors = new StringBuilder();
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            string title = (string)js.ExecuteScript("return document.title");

        }


        [TestMethod]
        [TestCategory("Regression /Nature/Test")]
        public void NatureSearchTest()
        {
            driver.Navigate().GoToUrl(baseURL + "/");
            driver.Navigate().Refresh();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(20));

            NatureSearch_Selenium Search = new NatureSearch_Selenium(driver);
            Search.SearchField("architecture");


        }

        
    }


}

