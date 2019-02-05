using MotorsProject.Pages;
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
        HomePage homePage = new HomePage();
        SearchResultPage searchResultPage = new SearchResultPage();

        [Given(@"I am navigate to Motors homepage")]
        public void GivenIAmNavigateToMotorsHomepage()
        {

            homePage.IsHomePageDisplayed();
                
        }

        [When(@"I enter my postcode")]
        public void WhenIEnterMyPostcode()
        {
            homePage.EnterPostcode("Ol98le");
            
        }

        [When(@"I select Audi as the car make")]
        public void WhenISelectAudiAsTheCarMake()
        {
            homePage.SelectCarMake("Audi");
        }

        [When(@"I select Q7 as the car model")]
        public void WhenISelectQAsTheCarModel()
        {
            homePage.SelectCarModel("Q7"); 
        }

        [When(@"I click on the  search button")]
        public void WhenIClickOnTheSearchButton()
        {
            searchResultPage = homePage.ClickOnSubmitButton(); 
        }

        [Then(@"the result of Audi Q7 cars are displayed")]
        public void ThenTheResultOfAudiQCarsAreDisplayed()
        {
            searchResultPage.IsSearchResultDisplayed("AUDI Q7");
        }

        [When(@"I enter my postcode as ""(.*)""")]
        public void WhenIEnterMyPostcodeAs(string pcode)
        {
            homePage.EnterPostcode(pcode);
        }

        [When(@"I select ""(.*)"" as the car make")]
        public void WhenISelectAsTheCarMake(string make)
        {
            homePage.SelectCarMake(make);
        }

        [When(@"I select ""(.*)"" as the car model")]
        public void WhenISelectAsTheCarModel(string model)
        {
            homePage.SelectCarModel(model);
        }

        [Then(@"the result of ""(.*)"" cars are displayed")]
        public void ThenTheResultOfCarsAreDisplayed(string sResult)
        {
            searchResultPage.IsSearchResultDisplayed(sResult);
          
        }

    }
}
