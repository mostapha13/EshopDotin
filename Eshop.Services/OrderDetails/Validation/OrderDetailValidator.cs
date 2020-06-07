using Eshop.Domains.OrderDetails.Entities;
using FluentValidation;

namespace Eshop.Services.OrderDetails.Validation
{
    public class OrderDetailValidator : AbstractValidator<OrderDetail>
    {

        public OrderDetailValidator()
        {
            RuleFor(od => od.ProductId).NotEmpty().NotNull().WithName("نام محصول");
            RuleFor(od => od.Count).NotEmpty().NotNull().WithName("تعداد");
            RuleFor(od => od.OrderId).NotEmpty().NotNull().WithName("سفارش");
            RuleFor(od => od.Price).NotEmpty().NotNull().WithName("قیمت");
        }

    }
}