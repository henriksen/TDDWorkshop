using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpecFlowDemo.Core.Models;
using SpecFlowDemo.Site.Controllers;

namespace SpecFlowDemo.UnitTests.Controllers
{
    [TestClass]
    public class CustomersControllerTests
    {
        [TestMethod]
        public void GetCreateShouldReturnCustomerView()
        {
            var customersController = new CustomersController();
            var result = customersController.Create() as ViewResult;

            Assert.AreEqual("Create", result.ViewName);
            Assert.IsInstanceOfType(result.ViewData.Model, typeof(Customer));
        }

        [TestMethod]
        public void PostCreateShouldSaveCustomerAndReturnDetailsView()
        {
            var customersController = new CustomersController();
            var customer = new Customer
            {
                Name = "Hugo Reyes",
                Email = "hreyes@dharmainitiative.com",
                Phone = "720-123-5477"
            };

            var result = customersController.Create(customer) as ViewResult;

            Assert.IsNotNull(result);
            Assert.AreEqual("Details", result.ViewName);
            Assert.IsInstanceOfType(result.ViewData.Model, typeof(Customer));

            customer = result.ViewData.Model as Customer;
            Assert.IsNotNull(customer);
            Assert.IsTrue(customer.Id > 0);
        }
    }
}
