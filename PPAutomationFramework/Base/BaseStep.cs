
using PPAutomationFramework.Config;
using PPAutomationFramework.Helpers;

namespace PPAutomationFramework.Base
{
    public class BaseStep : Base
    {
        
        public virtual void NaviateSite()
        {
            DriverContext.Browser.GoToUrl(Settings.AUT);
            LogHelpers.Write("Opened the browser !!!");
        }

    }
}
