using PPAutomationFramework.Base;
using PPAutomationFramework.Config;
using GoogleSampleTest.Pages;
using TechTalk.SpecFlow;


namespace GoogleSampleTest.Steps
{
    [Binding]
    class ExtendedSteps:BaseStep
    {
       

        public void NaviateSite()
        {
          DriverContext.Driver.Navigate().GoToUrl(Settings.AUT);
            //LogHelpers.Write("Opened the browser !!!");
        }

        [Given(@"I have navigated to the application")]
        public void GivenIHaveNavigatedToTheApplication()
        {
            NaviateSite();
            CurrentPage = GetInstance<GoogleHomePage>();

        }
    }
}
