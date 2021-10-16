using Dapper;
using Dapper_CRUD_Example.Entities.BaseEntity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dapper_MicroOrm_Example1.Entities.Concrete
{
    public class Products:BaseEntity
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int  UnitPrice { get; set; }
        public int  UnitsInStock { get; set; }


       
       
    }
}
   