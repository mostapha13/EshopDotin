using FluentValidation;
using Eshop.Domains.Products.Entities;


namespace Eshop.Services.Products.Validation
{
    public class ProductValidator:AbstractValidator<Product>
    {

        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().NotNull().MaximumLength(250).WithName("عنوان محصول");
            RuleFor(p => p.Price).NotEmpty().NotNull().WithName("قیمت");
        }
        
    }
}