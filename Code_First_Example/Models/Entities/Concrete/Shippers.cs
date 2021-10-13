using Code_First_Example.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Example.Models.Entities.Concrete
{
    public class Shippers:BaseEntity 
    {
        public string CompanyName { get; set; }
        public int Phone { get; set; }
        public virtual List<Orders> order { get; set; }
    }
}
