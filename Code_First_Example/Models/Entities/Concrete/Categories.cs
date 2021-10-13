using Code_First_Example.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Example.Models.Entities.Concrete
{
   public  class Categories:BaseEntity
    {
        public string CategoryName { get; set; }        
        public string Description { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
