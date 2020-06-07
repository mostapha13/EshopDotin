using System.ComponentModel.DataAnnotations;

namespace Eshop.Domains.Base
{
    public abstract class BaseEntity
    {
       
        public long Id { get; set; }
    }
}