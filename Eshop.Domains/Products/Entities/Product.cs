using System.Collections.Generic;
using Eshop.Domains.Base;
using Eshop.Domains.OrderDetails.Entities;


namespace Eshop.Domains.Products.Entities
{
    public class Product:BaseEntity
        
    {
        #region Proertise

        public string ProductName { get; set; }

        public float Price { get; set; }


        #endregion


        #region Relations

        public List<OrderDetail> OrderDetail { get; set; }

        #endregion

    }
}