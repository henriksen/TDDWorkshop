using NUnit.Framework;
using WatiN.Core;

namespace WebShop.AcceptanceTests.StepHelpers
{
    public class LogOn
    {
        public void LogOn()
        {
            WebBrowser.Current.GoTo("http://localhost:3542/Account/LogOn");

            WebBrowser.Current.TextField(Find.ByName("UserName")).TypeText("admin");
            WebBrowser.Current.TextField(Find.ByName("Password")).TypeText("123123");
            WebBrowser.Current.Button(Find.ByValue("Log On")).Click();

            Assert.IsTrue(WebBrowser.Current.Link(Find.ByText("Log Off")).Exists);
        }
    }
}