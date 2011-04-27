using SpecFlowDemo.Core.Models;

namespace SpecFlowDemo.Core.Repositories
{
    public interface ICustomerRepository
    {
        void Create(Customer customer);
    }
}
