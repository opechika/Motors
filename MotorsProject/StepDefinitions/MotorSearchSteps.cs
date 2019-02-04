using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MotorsProject.StepDefinitions
{
    [Binding]
    public sealed class MotorSearchSteps
    {
        IWebDriver driver;
        IWebElement banner;
        IWebElement Postcode;
        IWebElement CarMake;
        IWebElement CarModel;
        IWebElement SearchButton;
        IList<IWebElement> SearchResult;

        [Given(@"I am navigate to Motors homepage")]
        public void GivenIAmNavigateToMotorsHomepage()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.motors.co.uk/");
            driver.Manage().Window.Maximize();
            banner = driver.FindElement(By.ClassName("banner_continue--2NyXA"));
            banner.Click();
                
        }

        [When(@"I enter my postcode")]
        public void WhenIEnterMyPostcode()
        {
            Postcode = driver.FindElement(By.Name("PostCode"));
            Postcode.SendKeys("OL98LE");
            
        }

        [When(@"I select Audi as the car make")]
        public void WhenISelectAudiAsTheCarMake()
        {
            CarMake = driver.FindElement(By.Id("Make"));
            SelectElement selectElement = new SelectElement(CarMake);
            selectElement.SelectByText("Audi");
        }

        [When(@"I select Q7 as the car model")]
        public void WhenISelectQAsTheCarModel()
        {
            CarModel = driver.FindElement(By.Id("Model"));
            SelectElement selectElement = new SelectElement(CarModel);
            selectElement.SelectByText("Q7");
        }

        [When(@"I click on the  search button")]
        public void WhenIClickOnTheSearchButton()
        {
            SearchButton = driver.FindElement(By.ClassName("sp__btn-title"));
            SearchButton.Click();
        }

        [Then(@"the result of Audi Q7 cars are displayed")]
        public void ThenTheResultOfAudiQCarsAreDisplayed()
        {
            SearchResult = driver.FindElements(By.CssSelector("h3.title"));

            foreach (IWebElement result in SearchResult)
            {
                var resultText = result.Text;
                Assert.True(resultText.Contains("AUDI Q7"));
            }
        }

        [When(@"I enter my postcode as ""(.*)""")]
        public void WhenIEnterMyPostcodeAs(string pcode)
        {
            Postcode = driver.FindElement(By.Name("PostCode"));
            Postcode.SendKeys(pcode);
        }

        [When(@"I select ""(.*)"" as the car make")]
        public void WhenISelectAsTheCarMake(string make)
        {
            CarMake = driver.FindElement(By.Id("Make"));
            SelectElement selectElement = new SelectElement(CarMake);
            selectElement.SelectByText(make);
        }

        [When(@"I select ""(.*)"" as the car model")]
        public void WhenISelectAsTheCarModel(string model)
        {
            CarModel = driver.FindElement(By.Id("Model"));
            SelectElement selectElement = new SelectElement(CarModel);
            selectElement.SelectByText(model);
        }

        [Then(@"the result of ""(.*)"" cars are displayed")]
        public void ThenTheResultOfCarsAreDisplayed(string sResult)
        {
            SearchResult = driver.FindElements(By.CssSelector("h3.title"));

            foreach (IWebElement result in SearchResult)
            {
                var resultText = result.Text;
                Assert.True(resultText.Contains(sResult));
            }
        }

    }
}
