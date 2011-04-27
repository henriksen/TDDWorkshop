using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using WatiN.Core;
using Table = TechTalk.SpecFlow.Table;

namespace SpecFlowDemo.AcceptanceTests.Steps
{
    [Binding]
    public class CreateCustomer
    {
        [When(@"I enter the following information")]
        public void WhenIEnterTheFollowingInformation(Table table)
        {
            foreach (var tableRow in table.Rows)
            {
                var field = WebBrowser.Current.TextField(Find.ByName(tableRow["Field"]));

                if (!field.Exists)
                    Assert.Fail(string.Format("Could not find {0} field on the page", field));

                field.TypeText(tableRow["Value"]);
            }
        }

        [Then(@"I should see the following details on the screen:")]
        public void ThenIShouldSeeTheFollowingDetailsOnTheScreen(Table table)
        {
            foreach (var tableRow in table.Rows)
            {
                var value = tableRow["Value"];

                Assert.IsTrue(WebBrowser.Current.ContainsText(value),
                    string.Format("Could not find text '{0}' on the page", value));
            }
        }
    }
}
