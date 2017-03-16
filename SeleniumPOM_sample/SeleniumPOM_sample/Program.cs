using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOM_sample
{
    class Program
    {
        //Create the reference for our browser
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {         
        }

        [SetUp]
        public void Initialize()
        {
            //Navigate to a web page
            driver.Navigate().GoToUrl("http://executeautomation.com/demosite/index.html");
            driver.Manage().Window.Maximize();

        }


        [Test]
        public void ExecuteTest()
        {
            //Title
            SeleniumSetMethods.SelectDropDown(driver, "TitleId", "Mr", "Id");

            //Initial
            SeleniumSetMethods.EnterText(driver, "Initial", "executesutomation", "Name");

            //Click
            SeleniumSetMethods.Click(driver, "Save", "Name");

        }


        [Test]
        public void NextTest()
        {
            Console.WriteLine("Next Method");
        }


        [TearDown]
        public void TestCleanUp()
        {
            driver.Close();
        }




       

    





    }
}
