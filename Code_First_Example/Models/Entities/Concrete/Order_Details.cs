using Code_First_Example.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Example.Models.Entities.Concrete
{
   public  class Order_Details:BaseEntity
    {
        public decimal Unitprice { get; set; }
        public decimal Quantity { get; set; }
        public int ProductId { get; set; }
        public int OrdersId { get; set; }
        public virtual Product Products { get; set; }
        public virtual Orders Orders { get; set; }
    }
}
