using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess.Commands;
using DataAccess.Commands.Context;
using DataAccess.Commands.Customers.Repository;
using DataAccess.Commands.OrderDetails.Repository;
using DataAccess.Commands.Orders.Repository;
using DataAccess.Commands.Products.Repository;
using DataAccess.Queries.Customers.Repository;
using DataAccess.Queries.OrderDetails.Repository;
using DataAccess.Queries.Orders.Repository;
using DataAccess.Queries.Products.Repository;
using Eshop.Domains;
using Eshop.Domains.Customers.Commands;
using Eshop.Domains.Customers.Queries;
using Eshop.Domains.OrderDetails.Commands;
using Eshop.Domains.OrderDetails.Queries;
using Eshop.Domains.Orders.Commands;
using Eshop.Domains.Orders.Queries;
using Eshop.Domains.Products.Commands;
using Eshop.Domains.Products.Queries;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Eshop.Presentation
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            #region DBContext

            services.AddDbContext<EshopContext>(option =>
            {
                option.UseSqlServer(Configuration["ConnectionStrings:CommandConnection"]);

            });

            #endregion


            #region IOC

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<ICustomerRepositoryCommand, CustomerRepositoryCommand>();
            services.AddScoped<ICustomerRepositoryQuery, CustomerRepositoryQuery>();

            services.AddScoped<IProductRepositoryCommand, ProductRepositoryCommand>();
            services.AddScoped<IProductRepositoryQuery, ProductRepositoryQuery>();

            services.AddScoped<IOrderRepositoryCommand, OrderRepositoryCommand>();
            services.AddScoped<IOrderRepositoryQuery, OrderRepositoryQuery>();


            services.AddScoped<IOrderDetailsRepositoryCommand, OrderDetailsRepositoryCommand>();
            services.AddScoped<IOrderDetailRepositoryQuery, OrderDetailRepositoryQuery>();


            #endregion


            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
