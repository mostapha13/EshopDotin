using Eshop.Domains.Orders.Entities;
using FluentValidation;

namespace Eshop.Services.Orders.Validation
{
    public class OrderValidator:AbstractValidator<Order>
    {
        public OrderValidator()
        {
            RuleFor(o => o.CustomerId).NotEmpty().NotNull().WithName("نام مشتری");
            RuleFor(o => o.IsFinally).NotNull().WithName("اتمام");
            RuleFor(o => o.OrderSum).NotEmpty().Null().WithName("جمع مبلغ");
            


        }
    }
}