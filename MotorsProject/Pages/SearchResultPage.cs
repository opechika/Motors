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
   public class SearchResultPage : BaseClass
    {
        IList<IWebElement> SearchResult;


        public void IsSearchResultDisplayed(string sResult)
        {

            SearchResult = GetElementsByCssSelector("h3.title");

            foreach (IWebElement result in SearchResult)
            {
                var resultText = result.Text;
                Assert.True(resultText.Contains(sResult));
            }
        }
    }
}
