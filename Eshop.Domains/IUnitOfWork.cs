using System;
using System.Threading.Tasks;
using Eshop.Domains.Customers.Commands;
using Eshop.Domains.Customers.Queries;
using Eshop.Domains.OrderDetails.Commands;
using Eshop.Domains.OrderDetails.Queries;
using Eshop.Domains.Orders.Commands;
using Eshop.Domains.Orders.Queries;
using Eshop.Domains.Products.Commands;
using Eshop.Domains.Products.Queries;

namespace Eshop.Domains
{
    public interface IUnitOfWork : IDisposable
    {



        ICustomerRepositoryCommand CustomerRepositoryCommand { get; }
        ICustomerRepositoryQuery CustomerRepositoryQuery { get; }


        IOrderDetailsRepositoryCommand OrderDetailsRepositoryCommand { get; }
        IOrderDetailRepositoryQuery OrderDetailRepositoryQuery { get; }


        IOrderRepositoryCommand OrderRepositoryCommand { get;}
        IOrderRepositoryQuery OrderRepositoryQuery { get;}

        IProductRepositoryCommand PropProductRepositoryCommand { get;}
        IProductRepositoryQuery ProductRepositoryQuery { get;}


        Task Save();
    }
}