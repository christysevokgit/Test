using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valtech.Test
{
  
    public class ValtechTest
    {
        public IWebDriver driver;
        public IWebElement IwebElement { get; set; }
        public IWebDriver WebDriverInstance { get; private set; }      
        private StringBuilder verificationErrors;
        public string baseURL;

    }


    /// <summary>
    /// 
    /// </summary>

   
    public void Initialize()

    {
        driver = new FirefoxDriver();

        //driver = new ChromeDriver(@"C:\Users\christy\Downloads\chromedriver_win32");          
        baseURL = "http://link.springer.com/";
        

    }













}
