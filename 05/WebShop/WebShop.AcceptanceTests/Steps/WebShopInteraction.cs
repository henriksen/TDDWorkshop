using TechTalk.SpecFlow;

namespace WebShop.AcceptanceTests.Steps
{
    [Binding]
    public class WebShopInteraction
    {
        [When(@"press ""Add to cart""")]
        public void WhenPressAddToCart()
        {
            ScenarioContext.Current.Pending();
        }
    }
}