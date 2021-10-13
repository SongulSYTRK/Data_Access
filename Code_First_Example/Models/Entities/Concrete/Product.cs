using Code_First_Example.Models.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Example.Models.Entities.Concrete
{
    public class Product:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; } //Foreignkey
        public int SuppliersId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Categories Category { get; set; }
        public virtual Suppliers Supplier { get; set; }
        public virtual List<Order_Details> orderDetails { get; set; }

    }
}
