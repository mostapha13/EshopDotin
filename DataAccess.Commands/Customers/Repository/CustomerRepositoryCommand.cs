using System.Collections.Generic;
using System.Threading.Tasks;
using DataAccess.Commands.Context;
using Eshop.Domains;
using Eshop.Domains.Customers.Commands;
using Eshop.Domains.Customers.Entities;
using Eshop.Domains.Customers.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Commands.Customers.Repository
{
    public class CustomerRepositoryCommand: ICustomerRepositoryCommand
    {
        private EshopContext _db;

        public CustomerRepositoryCommand(EshopContext db)
        {
            _db = db;
        }

        public async Task Add(Customer customer)
        {
            await _db.Customers.AddAsync(customer);
 
        }

        public async Task<List<Customer>> GetAllCustomer()
        {
            return await _db.Customers.ToListAsync();
        }


    }
}