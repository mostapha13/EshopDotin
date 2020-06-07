using System.Threading.Tasks;
using Eshop.Domains.Customers.Entities;

namespace Eshop.Domains.Customers.Commands.AddCustomer
{
    public interface IAddCustomerRepositoryCommand
    {
        Task AddCustomer(Customer customer);
    }
}