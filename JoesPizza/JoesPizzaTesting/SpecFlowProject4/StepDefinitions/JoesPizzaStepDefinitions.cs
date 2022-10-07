using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Collections.Generic;
using System.Linq;


namespace SpecFlowProject4.StepDefinitions
{
    [Binding]
    public class JoesPizzaStepDefinitions
    {
        private ChromeDriver chromedriver;
       

        public JoesPizzaStepDefinitions()
        {
            chromedriver = new ChromeDriver("C:\\Users\\shubham.pardale\\Downloads\\chromedriver_win32");
        }

        [Given(@"I have opened the Website url")]
        public void GivenIHaveOpenedTheWebsiteUrl()
        {

            chromedriver.Navigate().GoToUrl("https://joespizza20221007143859.azurewebsites.net");
        }

        [When(@"I will click on Buy Now of a specific pizza")]
        public void WhenIWillClickOnBuyNowOfASpecificPizza()
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromMilliseconds(5000));
            IWebElement BuyNow = chromedriver.FindElement(By.XPath("//*[@id='Buy']"));
            Thread.Sleep(3000);
            chromedriver.ExecuteScript("arguments[0].click();", BuyNow);
        }

        [Then(@"I will be redirected to the cart page")]
        public void ThenIWillBeRedirectedToTheCartPage()
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromMilliseconds(5000));
        }

        [Then(@"i will change the quantity and type (.*)")]
        public void ThenIWillChangeTheQuantityAndType(int p0)
        {
            IWebElement searchquantity = chromedriver.FindElement(By.XPath("//*[@id='quantity']"));
            var wait = new WebDriverWait(chromedriver, TimeSpan.FromSeconds(3));
            
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='quantity']")));
            Thread.Sleep(2000);
            searchquantity.SendKeys(Keys.Control);
            searchquantity.SendKeys(Keys.Delete);
            searchquantity.SendKeys(p0.ToString());

            
        }

        [Then(@"i will upadte the order")]
        public void ThenIWillUpadteTheOrder()
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromMilliseconds(5000));
            IWebElement update = chromedriver.FindElement(By.XPath("//*[@id='update']"));
            Thread.Sleep(3000);
            chromedriver.ExecuteScript("arguments[0].click();", update);
        }


        [When(@"I will click on Pay Now")]
        public void WhenIWillClickOnPayNow()
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromMilliseconds(5000));
            IWebElement pay = chromedriver.FindElement(By.XPath("//*[@id='pay']"));
            Thread.Sleep(3000);
            chromedriver.ExecuteScript("arguments[0].click();", pay);
        }

        [Then(@"Payment confirmation page is opened")]
        public void ThenPaymentConfirmationPageIsOpened()
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromMilliseconds(5000));
        }
    }
}
