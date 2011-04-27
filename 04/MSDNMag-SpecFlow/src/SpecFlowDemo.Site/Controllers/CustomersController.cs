using System.Web.Mvc;
using SpecFlowDemo.Core.Models;
using SpecFlowDemo.Core.Repositories;
using SpecFlowDemo.Infrastructure.Repositories;

namespace SpecFlowDemo.Site.Controllers
{
    public class CustomersController : Controller
    {
        ICustomerRepository _repository;

        public CustomersController()
        {
            _repository = new CustomerRepository();
        }

        public ActionResult Create()
        {
            return View("Create", new Customer());
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(Customer customer)
        {
            _repository.Create(customer);

            return View("Details", customer);    
        }
    }
}
