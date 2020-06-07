using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Eshop.Domains.Base;

using Eshop.Domains.OrderDetails;
using Eshop.Domains.Orders.Entities;

namespace Eshop.Domains.Customers.Entities
{
    public class Customer:BaseEntity
    {

        #region Propertise

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Credit { get; set; }
        
      
        #endregion



        #region Relations
         
        public List<Order> Orders { get; set; }
         

        #endregion


    }
}