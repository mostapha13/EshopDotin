using System.Threading.Tasks;
using Eshop.Domains.Customers.Entities;

namespace Eshop.Domains.Customers.Commands
{
    public interface ICustomerRepositoryCommand
    {
       Task Add(Customer customer);
    }
}