using TechTalk.SpecFlow;

namespace WebShop.AcceptanceTests.Steps
{
    [Binding]
    public class SiteNavigation
    {
        [When(@"I open the shop page")]
        public void WhenIOpenTheShopPage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}