using Eshop.Domains.Orders.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Commands.Orders.Config
{
    public class OrderConfig:IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(o => o.IsFinally).IsRequired();
            builder.Property(o => o.OrderSum).IsRequired();
            builder.Property(o => o.CustomerId).IsRequired();

            builder.HasMany(o => o.OrderDetails)
                .WithOne(o => o.Order)
                .HasForeignKey(o => o.OrderId)
                .OnDelete(DeleteBehavior.Restrict);

           
        }
    }
}