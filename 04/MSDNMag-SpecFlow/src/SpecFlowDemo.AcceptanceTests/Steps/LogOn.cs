using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using WatiN.Core;

namespace SpecFlowDemo.AcceptanceTests.Steps
{
    [Binding]
    public class LogOn
    {
        [Given(@"I am logged into the site as an administrator")]
        public void GivenIAmLoggedIntoTheSiteAsAnAdministrator()
        {
            WebBrowser.Current.GoTo("http://localhost:3542/Account/LogOn");

            WebBrowser.Current.TextField(Find.ByName("UserName")).TypeText("admin");
            WebBrowser.Current.TextField(Find.ByName("Password")).TypeText("pass123");
            WebBrowser.Current.Button(Find.ByValue("Log On")).Click();

            Assert.IsTrue(WebBrowser.Current.Link(Find.ByText("Log Off")).Exists);
        }
    }
}