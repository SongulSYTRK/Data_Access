using Dapper_MicroOrm_Example1.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_MicroOrm_Example1.Entities.Concrete
{
   public  class Employees:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate  { get; set; }
    }
}
