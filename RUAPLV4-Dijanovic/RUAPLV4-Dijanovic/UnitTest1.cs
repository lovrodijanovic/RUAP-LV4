using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class SubscribeToNewsletter
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;

        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Test]
        public void TheSubscribeToNewsletterTest()
        {
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
            driver.FindElement(By.Id("newsletter-email")).Click();
            driver.FindElement(By.Id("newsletter-email")).Clear();
            driver.FindElement(By.Id("newsletter-email")).SendKeys("asdasdasd@gmail.copm");
            driver.FindElement(By.Id("newsletter-subscribe-button")).Click();
        }

        [Test]
        public void TheAddItemToCompareListTest()
        {
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
            driver.FindElement(By.XPath("//div[4]/div/div/a/img")).Click();
            driver.FindElement(By.XPath("//input[@value='Add to compare list']")).Click();
        }

        [Test]
        public void TheAddItemToShoppingCartTest()
        {
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
            driver.FindElement(By.XPath("//div[3]/div/div/a/img")).Click();
            driver.FindElement(By.Id("add-to-cart-button-31")).Click();
        }

        [Test]
        public void TheAddReviewTest()
        {
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
            driver.FindElement(By.XPath("//div[3]/div/div/a/img")).Click();
            driver.FindElement(By.LinkText("Add your review")).Click();
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/productreviews/31");
            driver.FindElement(By.Id("AddProductReview_Title")).Click();
            driver.FindElement(By.Id("AddProductReview_Title")).Clear();
            driver.FindElement(By.Id("AddProductReview_Title")).SendKeys("14.1 inch Laptop");
            driver.FindElement(By.Id("AddProductReview_ReviewText")).Click();
            driver.FindElement(By.Id("AddProductReview_ReviewText")).Clear();
            driver.FindElement(By.Id("AddProductReview_ReviewText")).SendKeys("Product is very good");
            driver.FindElement(By.Id("addproductrating_3")).Click();
            driver.FindElement(By.Name("add-review")).Click();
        }

        [Test]
        public void TheBuyItemTest()
        {
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/");
            driver.FindElement(By.XPath("//li[@id='topcartlink']/a/span")).Click();
            driver.FindElement(By.Id("termsofservice")).Click();
            driver.FindElement(By.Id("checkout")).Click();
        }
    }
}
