using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Threading;

namespace AladiniTestAutomation
{
    public class AddItemToCart
    {
        [TestMethod]
        public void TA_AddItemToCart()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://aladini.al/");

            IWebElement Hyr = driver.FindElement(By.ClassName("login"));
            Hyr.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait1.Until(ExpectedConditions.ElementIsVisible(By.Id("SubmitCreate")));

            IWebElement AdresaEmail = driver.FindElement(By.Id("email"));
            AdresaEmail.SendKeys("elmaxhelo21@gmail.com");

            IWebElement Password = driver.FindElement(By.Id("passwd"));
            Password.SendKeys("testtest");

            IWebElement LogInAccount = driver.FindElement(By.Id("SubmitLogin"));
            LogInAccount.Click();
            
            Thread.Sleep(50000);
            driver.Dispose();

        }
    }
    
}
