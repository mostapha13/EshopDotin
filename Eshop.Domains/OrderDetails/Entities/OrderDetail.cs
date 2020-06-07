using Eshop.Domains.Base;
using Eshop.Domains.Customers.Entities;
using Eshop.Domains.Orders.Entities;
using Eshop.Domains.Products.Entities;

namespace Eshop.Domains.OrderDetails.Entities
{
    public class OrderDetail:BaseEntity
    {

        #region Propertise

        public long OrderId { get; set; }

        public long ProductId { get; set; }

        public int Count { get; set; }

        public float Price { get; set; }


        #endregion


        #region Relations



        public Order Order { get; set; }

        public Product Product { get; set; }

        #endregion


    }
}