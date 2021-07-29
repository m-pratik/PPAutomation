using OpenQA.Selenium;
using PPAutomationFramework.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleSampleTest.Pages
{
   internal class GoogleHomePage:BasePage
    {
       

        IWebElement InputSearch => DriverContext.Driver.FindElement(By.Name("q"));

        public void FillInput(string query)
        {
            InputSearch.SendKeys("Hey this is Testing ");
        }
    }
}
