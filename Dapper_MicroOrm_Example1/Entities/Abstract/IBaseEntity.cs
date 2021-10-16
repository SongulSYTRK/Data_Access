using Dapper_MicroOrm_Example1.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_MicroOrm_Example1.Entities.Abstract
{
   public abstract class IBaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1)]
        public int Id { get; set; }


        public decimal? UpdateDate { get; set; }
        public decimal? DeleteDate { get; set; }


        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate{ get=> _createDate; set=> _createDate=value; }


        private Status _status = Status.Active;
        public Status Status  { get=> _status; set=>_status=value; }
    }
}
