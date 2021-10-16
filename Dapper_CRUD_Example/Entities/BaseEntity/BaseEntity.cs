using Dapper_CRUD_Example.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_CRUD_Example.Entities.BaseEntity
{
   public abstract  class BaseEntity
    {
        public int Id { get; set; }


        public decimal? UpdateDate { get; set; }
        public decimal? DeleteDate { get; set; }


        private DateTime _createDate = DateTime.Now;
        public DateTime CreateDate { get => _createDate; set => _createDate = value; }


        private Status _status = Status.Active;
        public Status Status { get => _status; set => _status = value; }
    }
}
