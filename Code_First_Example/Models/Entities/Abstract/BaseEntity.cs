using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Example.Models.Entities.Abstract
{
    public abstract class BaseEntity
    {
        [Key]  //Id:Primary Key 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int Id { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate { get=>_createDate; set=> _createDate=value; }
    }
}
