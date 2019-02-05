using MotorsProject.Helper;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorsProject.Pages
{
    public  class HomePage : BaseClass
    {
        IWebElement title;
        IWebElement Postcode;
        IWebElement CarMake;
        IWebElement CarModel;
        IWebElement SearchButton;



        public void IsHomePageDisplayed()
        {
            title = GetElementByCssSelector("h2.title");
            Assert.True(title.Displayed);
        }

        public void EnterPostcode(string code)
        {
            Postcode = driver.FindElement(By.Name("PostCode"));
            Postcode.SendKeys(code);
        }
        public void SelectCarMake(string make)
        {
            CarMake = driver.FindElement(By.Id("Make"));
            SelectByText(CarMake, "Audi");
            
        }
        public void SelectCarModel(string model)
        {
            CarModel = driver.FindElement(By.Id("Model"));
            SelectByText(CarModel, "Q7");
            

        }
        public SearchResultPage ClickOnSubmitButton()
        {

            SearchButton = driver.FindElement(By.ClassName("sp__btn-title"));
            SearchButton.Click();
            return new SearchResultPage();
        }
    }

}
