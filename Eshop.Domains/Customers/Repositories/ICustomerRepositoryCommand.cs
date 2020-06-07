using System.Collections.Generic;
using System.Threading.Tasks;
using Eshop.Domains.Customers.Entities;

namespace Eshop.Domains.Customers.Repositories
{
    public interface ICustomerRepositoryCommand
    {
       Task Add(Customer customer);
       Task<List<Customer>> GetAllCustomer();
    }
}