using TechTalk.SpecFlow;

namespace WebShop.AcceptanceTests.Steps
{
    //| Name    | Price | InStock |
    //| "Dings" | 50.00 | True    |
    [Binding]
    public class CreateProducts
    {
        [Given(@"The product")]
        public void GivenTheProduct(Table table)
        {
            ScenarioContext.Current.Pending();
        }
    }
}