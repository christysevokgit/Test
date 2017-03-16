using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace SeleniumPOM_sample
{
    class SeleniumSetMethods
    {
        // Enter Text
        public static void EnterText(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "Id")
                driver.FindElement(By.Id(element)).Click();

            if (elementtype == "Name")
                driver.FindElement(By.Name(element)).Click();
        }

        // Click into a button, Checkbox, option etc
        public static void Click(IWebDriver driver, string element, string elementtype)
        {
            if (elementtype == "Id")
                driver.FindElement(By.Id(element)).Click();

            if (elementtype == "Name")
                driver.FindElement(By.Id(element)).Click();
        }


        //Selecting dropdown control
        public static void SelectDropDown(IWebDriver driver, string element, string value, string elementtype)
        {
            if (elementtype == "Id")
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(value);

            if (elementtype == "Name")
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(value);

            if (elementtype == "XPath")
                new SelectElement(driver.FindElement(By.XPath(element))).SelectByText(value);
        }

    }
}
