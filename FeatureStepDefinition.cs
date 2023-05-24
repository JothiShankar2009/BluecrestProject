using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;

namespace InterviewSpecFlowProject.Steps
{
    [Binding]
    public sealed class FeatureStepDefinition
    {
        private IWebDriver driver;

        

        [Given(@"user navigate to url")]
        public void GivenUserNavigateToUrl()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.bluecrestwellness.com/";
            Thread.Sleep(3000);

        }
        [When(@"Click on the Health Assessment")]
        public void WhenClickOnTheHealthAssessment()
        {
            driver.FindElement(By.XPath("(//*[@class='navbar_link__TtsBe'])[1]")).Click();
            Thread.Sleep(2000);
            
        }
        [When(@"Click on the female cancer risk")]
        public void WhenClickOnTheFemaleCancerRisk()
        {
            //IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            //Thread.Sleep(2000);
            //js.ExecuteScript("window.scrollBy(0,950)");

            //driver.FindElement(By.XPath("(//*[@class='navbar_link__TtsBe navbar_nestedLink__wm6r0'])[2]")).Click();

            driver.FindElement(By.XPath("(//*[text()='Female Cancer Risk'])[1]")).Click();
            Thread.Sleep(2000);
            

        }

        [When(@"Validate user landed in the cancer risk female page")]
        public void WhenValidateUserLandedInTheCancerRiskFemalePage()
        {
            IWebElement headingText = driver.FindElement(By.XPath("(//*[@class='section-title_container__FFwAL'])[1]"));
            string text = headingText.Text;
            Console.WriteLine("Text : " + text);
            Assert.IsTrue(text.Contains("packages"));
            Thread.Sleep(2000);



        }


        [When(@"Click on the book now button")]
        public void WhenClickOnTheBookNowButton()
        {           
            
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,950)");

            // driver.FindElement(By.XPath("(//*[@class='packages-block_packageWrapper__waVtF'])[1]")).Click();
            driver.FindElement(By.XPath("(//*[contains(text(),'now')])[3]")).Click();
            Thread.Sleep(3000);          


        }
        [When(@"User will be landed on clinic search page successfully")]
        public void WhenUserWillBeLandedOnClinicSearchPageSuccessfully()
        {
            IWebElement searchText = driver.FindElement(By.XPath("(//*[text()='Choose a venue'])"));
            string text = searchText.Text;
            Console.WriteLine("Text : " + text);
            Assert.IsTrue(text.Contains("CHOOSE"));

        }

        [When(@"User enter location in text box")]
        public void WhenUserEnterLocationInTextBox()
        {
            driver.FindElement(By.Name("address_search")).SendKeys("Worthing");
            Thread.Sleep(2000);
            //driver.FindElement(By.XPath("//*[@class='btn venue-search-button custom-button-color']")).Click();
            driver.FindElement(By.Id("address-search-btn")).Click();
            driver.FindElement(By.XPath("//*[@id='onetrust-accept-btn-handler']")).Click();
                
        }

        [When(@"Choose location which nearest you")]
        public void WhenChooseLocationWhichNearestYou()
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,950)");
            driver.FindElement(By.XPath("//*[@id='venue-303-name']")).Click();
        }

        [When(@"choose date")]
        public void WhenChooseDate()
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,950)");
            driver.FindElement(By.XPath("//*[text()='22 Jun']")).Click();
        }

        [When(@"choose time")]
        public void WhenChooseTime()
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,950)");

            driver.FindElement(By.XPath("(//*[@class='time_cards_holder time'])[1]")).Click();
        }

        [When(@"Click on the confirm button")]
        public void WhenClickOnTheConfirmButton()
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,950)");
            driver.FindElement(By.XPath("//*[@class='btn venue-continue-button custom-button-color checkoutStepProceed submit-reservation']")).Click();
        }

        [Then(@"User will be landing on the order summary page")]
        public void ThenUserWillBeLandingOnTheOrderSummaryPage()
        {
            IWebElement oSText = driver.FindElement(By.XPath("(//*[text()='Order Summary'])"));
            string text = oSText.Text;
            Console.WriteLine("Text : " + text);
            Assert.IsTrue(text.Contains("Order"));

        }

        [Then(@"Click on the continue button")]
        public void ThenClickOnTheContinueButton()
        {
            //IJavaScriptExecutor js = driver as IJavaScriptExecutor;
            //Thread.Sleep(2000);
            //js.ExecuteScript("window.scrollBy(0,950");
            driver.FindElement(By.Id("checkoutContinueButton")).Click();
               
        }

        [Then(@"User will be landed in the personal details page successfully")]
        public void ThenUserWillBeLandedInThePersonalDetailsPageSuccessfully()
        {
            IWebElement personalDealisPage = driver.FindElement(By.XPath("//*[text()='Personal details']"));
            string text = personalDealisPage.Text;
            Console.WriteLine("Text : " + text);
            Assert.IsTrue(text.Contains("Personal"));

        }
        











    }
}
