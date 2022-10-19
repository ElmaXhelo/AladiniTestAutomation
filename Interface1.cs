using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V102.IndexedDB;
using OpenQA.Selenium.DevTools.V102.Input;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
namespace AladiniTestAutomation
{
    [TestClass]
    public class AladiniAutomation2
    {
        public static
        ChromeDriver driver = new ChromeDriver();
        WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        public void Launch()
        {
            driver.Manage().Window.Maximize();
            driver.Manage().Cookies.DeleteAllCookies();
            driver.Navigate().GoToUrl("https://aladini.al/");
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("header")));
        }
        public void Login()
        {
           

            Launch();
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("onesignal-slidedown-cancel-button")));
            driver.FindElement(By.Id("onesignal-slidedown-cancel-button")).Click();

            var hyrHome = driver.FindElement(By.XPath(@"//*[@id='header']/div[2]/div/div/nav/div[2]/a"));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("onesignal-slidedown-cancel-button")));

            driver.FindElement(By.Id("onesignal-slidedown-cancel-button"));
            wait.Until(ExpectedConditions.ElementToBeClickable(hyrHome));
            hyrHome.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("login_form")));
            var email = driver.FindElement(By.Id("email"));
            var password = driver.FindElement(By.Id("passwd"));

            var hyrButton = driver.FindElement(By.Id("SubmitLogin"));
            email.Click();
            email.SendKeys("elmaxhelo21@gmail.com");

            password.Click();
            password.SendKeys("testtest");
            hyrButton.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("center_column")));
        }
        [TestMethod]
        public void AddToCart()
        {
            Launch();
            Login();
            var searchbar = driver.FindElement(By.Id("bradSearchQuery"));
            searchbar.Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("df-topbar__dffullscreen")));

            var search = driver.FindElement(By.Id("df-searchbox__dffullscreen"));
            search.Click();
            search.SendKeys("Maus");

            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(@"/html/body/div[3]/div[2]/div[2]/div[1]/a")));
            var element = driver.FindElement(By.XPath(@"/html/body/div[3]/div[2]/div[2]/div[1]/a"));
            element.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("add_to_cart")));
            var addToCartBtn = driver.FindElement(By.XPath(@"/html/body/div[1]/div[2]/div[1]/div[2]/div/div[2]/div[2]/div/div/div[2]/div/div[7]/div/p[1]/button"));

            new Actions(driver)
            .ScrollToElement(driver.FindElement(By.Id("same_cat_pd")))
            .Perform();

            wait.Until(ExpectedConditions.ElementToBeClickable(addToCartBtn));
            addToCartBtn.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"layer_cart\"]/div[1]/div[2]/div[4]/a")));
            var perfundoPorosine = driver.FindElement(By.XPath("//*[@id=\"layer_cart\"]/div[1]/div[2]/div[4]/a"));
            perfundoPorosine.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"cart_summary\"]/div[2]/p/a[2]")));
            var buy = driver.FindElement(By.XPath("//*[@id=\"cart_summary\"]/div[2]/p/a[2]"));

            new Actions(driver)
            .ScrollToElement(driver.FindElement(By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/div/div[2]/div/div[1]/div/div[4]/div[1]/a")))
            .Perform();
            buy.Click();

            Assert.AreEqual("Order - Aladini", driver.Title);
            driver.Dispose();
        }
    }
}
