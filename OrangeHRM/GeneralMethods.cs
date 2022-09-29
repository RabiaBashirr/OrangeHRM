using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM_Project
{

    public class GeneralMethods
    {
        public static IWebDriver driver; //ad driver

        public static IWebDriver SeleniumBrowserInit(String browserName)
        {
            if (browserName != null)
            {
                if (browserName == "Chrome")
                {
                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                }

                else if (browserName == "MsEdge")
                    driver = new EdgeDriver();
            }
            return driver;
        }


        public static void Navigation(string url)
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
