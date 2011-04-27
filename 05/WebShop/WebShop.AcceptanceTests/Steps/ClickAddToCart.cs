using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using WebShop.AcceptanceTests.StepHelpers;

namespace WebShop.AcceptanceTests.Steps
{
    [Binding]
    class ClickAddToCart
    {
        [When(@"I press ""Add to Cart""")]
        public void WhenIPressAddToCart()
        {
           WebBrowser.Current.Buttons
               .Where(button=>button.Value=="Add to cart")
               .First().Click();
        }
    }
}
