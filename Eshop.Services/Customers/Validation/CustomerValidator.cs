using FluentValidation;
using Eshop.Domains.Customers.Entities;

namespace Eshop.Services.Customers.Validation
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c=>c.FirstName).NotEmpty().NotNull().MaximumLength(250).WithName("نام");

            RuleFor(c=>c.LastName).NotEmpty().NotNull().MaximumLength(250).WithName("نام خانوادگی");

            RuleFor(c=>c.Credit).NotEmpty().NotNull().WithName("اعتبار");


        }
    }
}