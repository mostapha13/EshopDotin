
using DataAccess.Commands.Customers.Config;
using DataAccess.Commands.OrderDetails.Config;
using DataAccess.Commands.Orders.Config;
using DataAccess.Commands.Products.Config;
using Eshop.Domains.Customers.Entities;
using Eshop.Domains.OrderDetails.Entities;
using Eshop.Domains.Orders.Entities;
using Eshop.Domains.Products.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Commands.Context
{
    public class EshopContext:DbContext
    {

        public EshopContext(DbContextOptions<EshopContext> options):base(options)
        {
            
        }


        public DbSet<Product> Products { get; set; }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }


        #region OnModelCreating

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {




            #region Configuration

            modelBuilder.ApplyConfiguration(new CustomerConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());
            modelBuilder.ApplyConfiguration(new OrderConfig());
        //    modelBuilder.ApplyConfiguration(new OrderDetailConfig());



            #endregion






            base.OnModelCreating(modelBuilder);
        }


        #endregion



    }
}