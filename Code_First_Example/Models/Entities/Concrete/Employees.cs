using Code_First_Example.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Example.Models.Entities.Concrete
{
  public   class Employees:BaseEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Title { get; set; }
        public string Region { get; set; }
        public virtual List<Orders> order { get; set; }
    }
}
