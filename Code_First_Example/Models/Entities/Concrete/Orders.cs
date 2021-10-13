using Code_First_Example.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Example.Models.Entities.Concrete
{
    public class Orders:BaseEntity
    {
        public DateTime OrderDate { get; set; }
        public DateTime ShipDate { get; set; }
        public string ShipName { get; set; }
        public int CustomerId { get; set; }
        public int EmployeesId { get; set; }
        public int ShippersId { get; set; }
        public virtual List<Order_Details> orderDetail { get; set; }
        public virtual Employees Employee { get; set; }
        public virtual Shippers Shipper { get; set; }
        public virtual Customers Customer { get; set; }
    }
}
