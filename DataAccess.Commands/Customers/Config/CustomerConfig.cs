using Eshop.Domains.Customers.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Commands.Customers.Config
{
    public class CustomerConfig:IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(c=>c.FirstName).IsRequired().HasMaxLength(250);
            builder.Property(c => c.LastName).IsRequired().HasMaxLength(250);
            builder.Property(c=>c.Credit).IsRequired();

            builder.HasMany(c => c.Orders)
                .WithOne(c => c.Customer)
                .HasForeignKey(c => c.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}