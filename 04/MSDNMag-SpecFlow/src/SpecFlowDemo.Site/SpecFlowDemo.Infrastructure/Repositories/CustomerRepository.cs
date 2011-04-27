using System;
using SpecFlowDemo.Core.Models;
using SpecFlowDemo.Core.Repositories;

namespace SpecFlowDemo.Infrastructure.Repositories
{
    public class CustomerRepository: ICustomerRepository
    {
        public void Create(Customer customer)
        {
            customer.Id = new Random().Next(1, 2500);
        }
    }
}
