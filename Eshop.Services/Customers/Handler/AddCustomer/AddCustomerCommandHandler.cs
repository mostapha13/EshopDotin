using System.Threading;
using System.Threading.Tasks;
using Eshop.Domains.Customers.Commands;
using Eshop.Domains.Customers.Commands.AddCustomer;
using Eshop.Domains.Customers.Entities;
using Eshop.Domains.Enums;
using MediatR;

namespace Eshop.Services.Customers.Handler.AddCustomer
{
    public class AddCustomerCommandHandler:IRequestHandler<AddCustomerCommand,ResultStatus>
    {
        private IAddCustomerRepositoryCommand _db;

        public AddCustomerCommandHandler(IAddCustomerRepositoryCommand db)
        {
            _db = db;
        }



        public async Task<ResultStatus> Handle(AddCustomerCommand request, CancellationToken cancellationToken)
        {

            var customer = new Customer()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Credit = request.Credit
            };

            await _db.AddCustomer(customer);
            return ResultStatus.Success;

        }
    }
}