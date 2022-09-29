using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace OrangeHRM_Project
{
    [TestClass]
    public class Base
    {
        static IWebDriver driver = BrowserInit.SeleniumBrowserInit("Chrome");

        string url = "https://opensource-demo.orangehrmlive.com/web/index.php/auth/login";


        [TestMethod]
        public void LoginFunctionality()
        {
            BrowserInit.Navigation(url);

            LoginMethods log1 = new LoginMethods(driver);

            // TestCase-01
            log1.VerifywithEmptyFields();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2000);

            /*
             * //Explicit Wait to show results
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));       
            wait.until(ExpectedConditions.presenceOfElementLocated(locator));          
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            */


            // TestCase-02
            log1.LoginNonExistingUser();
            // Implicit Wait to show results
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2000);


            // TestCase-03
            log1.ValidLogin();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1000);
        }
    }
}
