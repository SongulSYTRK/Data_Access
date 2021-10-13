using Code_First_Example.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Example.Models.Entities.Concrete
{
   public class Suppliers:BaseEntity
    {
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public int Fax { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
