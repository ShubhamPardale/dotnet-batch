using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System.Collections.Generic;
using System.Linq;

namespace SpecFlowProject5.StepDefinitions
{
    [Binding]
    public class JoesPizza1StepDefinitions
    {
        private ChromeDriver chromedriver;

        public JoesPizza1StepDefinitions()
        {
            chromedriver = new ChromeDriver("C:\\Users\\shubham.pardale\\Downloads\\chromedriver_win32");
        }


        [Given(@"I have opened the Website Url")]
        public void GivenIHaveOpenedTheWebsiteUrl()
        {

            chromedriver.Navigate().GoToUrl("https://localhost:7299/");
        }

        [When(@"I will click on Buy Now of a pizza")]
        public void WhenIWillClickOnBuyNowOfAPizza()
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromMilliseconds(5000));
            IWebElement BuyNow = chromedriver.FindElement(By.XPath("//*[@id='Buy']"));
            Thread.Sleep(3000);
            chromedriver.ExecuteScript("arguments[0].click();", BuyNow);
        }

        [Then(@"I will be redirected to the cart")]
        public void ThenIWillBeRedirectedToTheCar()
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromMilliseconds(5000));
        }

        [Then(@"i will go back to menu")]
        public void ThenIWillGoBackToMenu()
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromMilliseconds(5000));
            IWebElement back = chromedriver.FindElement(By.XPath("//*[@id='back']"));
            Thread.Sleep(3000);
            chromedriver.ExecuteScript("arguments[0].click();", back);
        }

        [Then(@"i will add another pizza")]
        public void ThenIWillAddAnotherPizza()
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromMilliseconds(5000));
            IWebElement another = chromedriver.FindElement(By.XPath("/html/body/div/main/div[2]/div[2]/div/a"));
            Thread.Sleep(3000);
            chromedriver.ExecuteScript("arguments[0].click();", another);
        }

        [Then(@"i will cancel one pizza")]
        public void ThenIWillCancelOnePizza()
        {
            Thread.Sleep(1000);
            IWebElement cancel = chromedriver.FindElement(By.XPath("//*[@id='cancel']"));
            Thread.Sleep(1000);
            chromedriver.ExecuteScript("arguments[0].click();", cancel);
        }

        [When(@"the button Pay Now is clicked")]
        public void WhenTheButtonPayNowIsClicked()
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromMilliseconds(5000));
            IWebElement pay = chromedriver.FindElement(By.XPath("//*[@id='pay']"));
            Thread.Sleep(3000);
            chromedriver.ExecuteScript("arguments[0].click();", pay);
        }

        [Then(@"Order confirmation page is opened")]
        public void ThenOrderConfirmationPageIsOpened()
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromMilliseconds(5000));
        }
    }
}
