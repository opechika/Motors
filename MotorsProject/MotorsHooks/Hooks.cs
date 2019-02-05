using MotorsProject.Helper;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MotorsProject.MotorsHooks
{
    [Binding]
    public sealed class Hooks : BaseClass
    {
        IWebElement banner;

        [BeforeScenario]
        public void BeforeScenario()
        {
            LaunchBrowser("Chrome");
            LaunchUrl("https://www.motors.co.uk");
            banner = GetElementByClassName("banner_continue--2NyXA");
            banner.Click();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            CloseBrowser();
        }
    }
}
