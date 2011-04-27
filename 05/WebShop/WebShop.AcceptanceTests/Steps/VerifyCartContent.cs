using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WebShop.AcceptanceTests.StepHelpers;

namespace WebShop.AcceptanceTests.Steps
{
    [Binding]
    class VerifyCartContent
    {
        [Then(@"the cart should have an item")]
        public void ThenTheCartShouldHaveAnItem()
        {
            var result = WebBrowser.Current.ContainsText("test - 45,00");

            Assert.IsTrue(result);
        }

    }
}
