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
    [TestClass]
    public class CreateNewAccount
    {

        [TestMethod]
        public void TA_CreateNewAccount()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://aladini.al/");

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"header\"]/div[2]/div/div/nav/div[2]/a"))); 

            IWebElement jotani = driver.FindElement(By.Id("onesignal-slidedown-cancel-button"));
            jotani.Click();
            driver.SwitchTo().Alert().Dismiss();

            //Thread.Sleep(5000);

            IWebElement Hyr = driver.FindElement(By.ClassName("login"));
            Hyr.Click();

            WebDriverWait wait1 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait1.Until(ExpectedConditions.ElementIsVisible(By.Id("SubmitCreate")));

            IWebElement AdresaEmail = driver.FindElement(By.Id("email_create"));
            AdresaEmail.SendKeys("elmaxhelo21@gmail.com");

            IWebElement KrijoLlogari = driver.FindElement(By.Id("SubmitCreate"));
            KrijoLlogari.Click();

            WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"account-creation_form\"]/div[2]")));

            IWebElement Mrs = driver.FindElement(By.Id("id_gender2"));
            Mrs.Click();

            IWebElement Emri = driver.FindElement(By.Id("customer_firstname"));
            Emri.Click();
            Emri.SendKeys("Elma");

            IWebElement Mbiemri = driver.FindElement(By.Id("customer_lastname"));
            Mbiemri.Click();
            Mbiemri.SendKeys("Xhelo");

            IWebElement Email = driver.FindElement(By.Id("elmaxhelo21@gmail.com"));
            Email.Click();

            IWebElement Fjalekalimi = driver.FindElement(By.Id("passwd"));
            Fjalekalimi.Click();
            Fjalekalimi.SendKeys("testtest");

            IWebElement days = driver.FindElement(By.Id("days"));
            SelectElement selector = new SelectElement(driver.FindElement(By.Id("days")));
            selector.SelectByValue("21");

            IWebElement months =  driver.FindElement(By.Id("months"));
            SelectElement selector2 = new SelectElement(driver.FindElement(By.Id("months")));
            selector2.SelectByValue("8");

            IWebElement years = driver.FindElement(By.Id("years"));
            SelectElement selector3 = new SelectElement(driver.FindElement(By.Id("years")));
            selector3.SelectByValue("2001");

            //IWebElement Newsletter = driver.FindElement(By.Id("newsletter"));
            //Newsletter.Click();

            IWebElement Regjistrohu = driver.FindElement(By.XPath("//*[@id=\"submitAccount\"]"));
            Regjistrohu.Click();

            Thread.Sleep(5000);
            driver.Dispose();
        }
    }
}





