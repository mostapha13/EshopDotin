using System.Collections.Generic;
using Eshop.Domains.Base;
using Eshop.Domains.Customers.Entities;
using Eshop.Domains.OrderDetails.Entities;

namespace Eshop.Domains.Orders.Entities
{
    public class Order:BaseEntity
    {

        #region Propertise

        public long CustomerId { get; set; }

        public float OrderSum { get; set; }

        public bool IsFinally { get; set; }


        #endregion


        #region Relations

        public List<OrderDetail> OrderDetails { get; set; }

        public Customer Customer { get; set; }

  

        #endregion

    }
}