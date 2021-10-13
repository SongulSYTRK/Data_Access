using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_PhoneDirectory_Example.Models.Entities.Abstract
{
    public abstract class BaseEntityPhone
    {
        public int Id { get; set; }
       

        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate { get => _createDate; set => _createDate = value; }

        public DateTime? UpdateDate { get; set; } // decimal? = null geçilebilir demektir 
        public DateTime? DeleteDate { get; set; }
    }
}
