using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using WebShop.AcceptanceTests.StepHelpers;

namespace WebShop.AcceptanceTests.Steps
{
     [Binding]
    class BrowseShop
    {
            [Given(@"I'm browsing the shop")]
            public void GivenIMBrowsingTheShop()
            {
                WebBrowser.Current.GoTo("http://localhost:50000/Shop");
            }
    }
}
