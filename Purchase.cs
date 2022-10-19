using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium.Interactions;
namespace Purchaseitem
{
    [TestClass]
    public class Purchase
    {
        [TestMethod]
        public void TA_Purchase()
        {
           IWebDriver driver = new ChromeDriver();

           driver.Manage().Window.Maximize();
           driver.Manage().Cookies.DeleteAllCookies();
           driver.Navigate().GoToUrl("https://aladini.al/");

           WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
           wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"header\"]/div[2]/div/div/nav/div[2]")));

           IWebElement jotani = driver.FindElement(By.Id("onesignal-slidedown-cancel-button"));
           jotani.Click();

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

           IWebElement Search = driver.FindElement(By.Id("bradSearchQuery"));
           Search.Click();

           WebDriverWait wait2 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
           wait2.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"df-searchbox__dffullscreen\"]")));

           IWebElement Search1 = driver.FindElement(By.XPath("//*[@id=\"df-searchbox__dffullscreen\"]"));
           Search1.SendKeys("Tastiere");

           WebDriverWait wait3 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
           wait3.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"df-results__wrapper__dffullscreen\"]/div[1]/a")));

           IWebElement Item = driver.FindElement(By.XPath("//*[@id=\"df-results__wrapper__dffullscreen\"]/div[1]/a"));
           Item.Click();

           WebDriverWait wait4 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
           wait4.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"center_column\"]/div[2]/div[2]/div/div/div[1]/div/div[3]/div")));

           IWebElement AddToCart = driver.FindElement(By.XPath("//*[@id=\"add_to_cart\"]/button"));
           AddToCart.Click();

           WebDriverWait wait5 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
           wait5.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"layer_cart\"]/div[1]/div[2]")));

           IWebElement finnishorder = new WebDriverWait(driver, TimeSpan.FromSeconds(35))
           .Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"layer_cart\"]/div[1]/div[2]/div[4]/a")));
           finnishorder.Click();
           
           WebDriverWait wait6 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
           wait6.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"cart_summary\"]/div[2]")));
           
           IWebElement Finnishorder1 = new WebDriverWait(driver, TimeSpan.FromSeconds(35))
           .Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@id=\"cart_summary\"]/div[2]/p/a[2]")));
           Finnishorder1.Click();
           
           WebDriverWait wait7 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
           wait7.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"carrier_area\"]/div[1]")));
            
           Assert.AreEqual("Order - Aladini", driver.Title);

           IWebElement Adresanew = driver.FindElement(By.XPath("//*[@id=\"center_column\"]/form/div[1]/p/a"));
           Adresanew.Click();

           IWebElement Emri = driver.FindElement(By.Id("firstname"));
           Emri.Click();

           IWebElement Mbiemri = driver.FindElement(By.Id("lastname"));
           Mbiemri.Click();

           IWebElement Adresa = driver.FindElement(By.Id("address1"));
           Adresa.Click();
           Adresa.SendKeys("Rruga e elbasanit");

           IWebElement Rrethi = driver.FindElement(By.Id("id_state"));
           SelectElement selector = new SelectElement(driver.FindElement(By.Id("id_state")));
           selector.SelectByValue("313");

           IWebElement Shteti = driver.FindElement(By.Id("id_country"));
           SelectElement selector1 = new SelectElement(driver.FindElement(By.Id("id_country")));
           selector1.SelectByValue("230");

           IWebElement Phone = driver.FindElement(By.Id("phone"));
           Phone.Click();
           Phone.SendKeys("0696180315");

           IWebElement City = driver.FindElement(By.Id("city"));
           City.Click();
           City.SendKeys("Tirana");

           IWebElement Mobile = driver.FindElement(By.Id("phone_mobile"));
           Mobile.Click();
           Mobile.SendKeys("0696180315");

           IWebElement Adresat = driver.FindElement(By.Id("alias"));
           Adresat.Clear();
           Adresat.SendKeys("Rruga e elbasant");

           IWebElement Submit = driver.FindElement(By.Id("submitAddress"));
           Submit.Click();

           WebDriverWait wait8 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
           wait8.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"columns\"]/div[2]")));

           IWebElement Shipping = driver.FindElement(By.Id("delivery_option_188944_0"));
           Shipping.Click();

           IWebElement Terms = driver.FindElement(By.Id("cgv"));
           Terms.Click();

           IWebElement SubmitToPay = driver.FindElement(By.XPath("//*[@id=\"carrier_area\"]/div[2]/p/button"));
           SubmitToPay.Click();

           WebDriverWait wait9 = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
           wait9.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"nettradecreditcard_payment_button\"]/a")));

           Thread.Sleep(30000);
           driver.Dispose();
        }
    }
}