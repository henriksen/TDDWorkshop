using TechTalk.SpecFlow;
using WatiN.Core;

namespace SpecFlowDemo.AcceptanceTests.StepHelpers
{
    [Binding]
    public class ScenarioHelper
    {
        [AfterScenario]
        public static void Close()
        {
            var link = WebBrowser.Current.Link(Find.ByText("Log Off"));

            if (link.Exists)
                link.Click();

            if (ScenarioContext.Current.ContainsKey("browser"))
                WebBrowser.Current.Close();
        }
    }
}