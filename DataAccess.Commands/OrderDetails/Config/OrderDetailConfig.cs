using Eshop.Domains.OrderDetails;
using Eshop.Domains.OrderDetails.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Commands.OrderDetails.Config
{
    public class OrderDetailConfig:IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.Property(d => d.Count).IsRequired();
            builder.Property(o => o.Price).IsRequired();
            builder.Property(o=>o.OrderId).IsRequired();
            builder.Property(o => o.ProductId).IsRequired();
        }
    }
}