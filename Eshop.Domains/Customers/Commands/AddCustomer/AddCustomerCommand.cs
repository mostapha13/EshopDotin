using Eshop.Domains.Enums;
using MediatR;

namespace Eshop.Domains.Customers.Commands.AddCustomer
{
    public class AddCustomerCommand:IRequest<ResultStatus>
    {

        #region Propertise

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Credit { get; set; }


        #endregion

    }
}