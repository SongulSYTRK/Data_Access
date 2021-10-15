using Dapper;
using Dapper_MicroOrm_Example1.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dapper_MicroOrm_Example1.Entities.Concrete
{
   public  class Categories:BaseEntity
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public void ctg(DataGridView datagridview)
        {
            using (IDbConnection con = new SqlConnection("Server =DESKTOP-Q9BCSBK;Database=Northwind;Integrated Security=True;"))  
            {
                con.Open();
                List<Categories> category = con.Query<Categories>("Select * from Categories Where CategoryName='Baklagiller' or CategoryId=4 ").ToList();
                datagridview.DataSource = category;
                con.Close();  
            }
        }
    }
}
