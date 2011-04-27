using TechTalk.SpecFlow;

namespace WebShop.AcceptanceTests.Steps
{
    [Binding]
    public class ShoppingCart
    {
        [Then(@"The shopping cart should contain the item")]
        public void ThenTheShoppingCartShouldContainTheItem(Table table)
        {
            ScenarioContext.Current.Pending();
        }
    }
}