using System.Threading.Tasks;
using DataAccess.Commands.Context;
using DataAccess.Commands.Customers.Repository;
using Eshop.Domains;
using Eshop.Domains.Customers.Commands;
using Eshop.Domains.Customers.Queries;
using Eshop.Domains.OrderDetails.Commands;
using Eshop.Domains.OrderDetails.Queries;
using Eshop.Domains.Orders.Commands;
using Eshop.Domains.Orders.Queries;
using Eshop.Domains.Products.Commands;
using Eshop.Domains.Products.Queries;

namespace DataAccess.Commands
{
    public class UnitOfWork : IUnitOfWork
    {
        private EshopContext _db;

        public UnitOfWork(EshopContext db)
        {
            _db = db;
        }


        private ICustomerRepositoryCommand _customerRepositoryCommand;
        private ICustomerRepositoryQuery _customerRepositoryQuery;

        public ICustomerRepositoryCommand CustomerRepositoryCommand
        {
            get
            {
                if (_customerRepositoryCommand != null)
                {
                    _customerRepositoryCommand = new CustomerRepositoryCommand(_db);
                }

                return _customerRepositoryCommand;
            }
          
        }




        public ICustomerRepositoryQuery CustomerRepositoryQuery { get; }
        public IOrderDetailsRepositoryCommand OrderDetailsRepositoryCommand { get;}
        public IOrderDetailRepositoryQuery OrderDetailRepositoryQuery { get; }
        public IOrderRepositoryCommand OrderRepositoryCommand { get;}
        public IOrderRepositoryQuery OrderRepositoryQuery { get;}
        public IProductRepositoryCommand PropProductRepositoryCommand { get;}
        public IProductRepositoryQuery ProductRepositoryQuery { get;}




        public async Task Save()
        {
            await _db.SaveChangesAsync();
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}