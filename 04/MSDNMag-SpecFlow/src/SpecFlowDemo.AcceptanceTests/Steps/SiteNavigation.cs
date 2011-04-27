using TechTalk.SpecFlow;

namespace SpecFlowDemo.AcceptanceTests.Steps
{
    [Binding]
    public class SiteNavigation
    {
        [Given(@"I am on the site home page")]
        public void GivenIAmOnTheSiteHomePage()
        {
            WebBrowser.Current.GoTo("http://localhost:3542");
        }
    }
}