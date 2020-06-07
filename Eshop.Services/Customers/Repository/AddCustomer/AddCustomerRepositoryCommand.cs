﻿using System.Threading.Tasks;
using Eshop.Domains;
using Eshop.Domains.Customers.Commands.AddCustomer;
using Eshop.Domains.Customers.Entities;

namespace Eshop.Services.Customers.Repository.AddCustomer
{
    public class AddCustomerRepositoryCommand: IAddCustomerRepositoryCommand
    {
        private IUnitOfWork _db;

        public AddCustomerRepositoryCommand(IUnitOfWork db)
        {
            _db = db;
        }


        public async Task AddCustomer(Customer customer)
        {
            await _db.CustomerRepositoryCommand.Add(customer);
            await _db.Save();
        }
    }
}