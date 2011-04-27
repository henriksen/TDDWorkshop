using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using WatiN.Core;
using Table = TechTalk.SpecFlow.Table;

namespace SpecFlowDemo.AcceptanceTests.Steps
{
    [Binding]
    public class Register
    {
        [When(@"I enter a random username")]
        public void WhenIEnteraRandomUsername()
        {
            var usernameField = WebBrowser.Current.TextField(Find.ByName("UserName"));

            if (!usernameField.Exists)
                Assert.Fail(string.Format("Could not find {0} field on the page", usernameField));

            var randomUsername = Guid.NewGuid().ToString();

            usernameField.TypeText(randomUsername);
        }

        [When(@"I complete the form with the following information:")]
        public void WhenICompleteTheFormWithTheFollowingInformation(Table table)
        {
            foreach (var tableRow in table.Rows)
            {
                var field = WebBrowser.Current.TextField(Find.ByName(tableRow["Field"]));

                if (!field.Exists)
                    Assert.Fail(string.Format("Could not find {0} field on the page", field));

                field.TypeText(tableRow["Value"]);
            }
        }
        
        [Then("I should see a link with the text \"(.*)\" on the page")]
        public void ThenIShouldSeeTextOnThePage(string linkText)
        {
            Assert.IsTrue(WebBrowser.Current.Link(Find.ByText(linkText)).Exists,
                string.Format("The following link text was not found on the page: {0}", linkText));
        }
    }
}    
