using PPAutomationFramework.Base;
using GoogleSampleTest.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace GoogleSampleTest.Steps
{
    [Binding]
    class GoogleInputSteps:BaseStep
    {
        

        [Given(@"I see the input field")]
        public void GivenISeeTheInputField()
        {
            CurrentPage.As<GoogleHomePage>().FillInput("Hello");
        }

        [When(@"I give the input")]
        public void WhenIGiveTheInput()
        {
            CurrentPage.As<GoogleHomePage>().FillInput("Hello");
        }

        [Then(@"It should display the result")]
        public void ThenItShouldDisplayTheResult()
        {
            Console.WriteLine("Hello");
        }

    }
}
