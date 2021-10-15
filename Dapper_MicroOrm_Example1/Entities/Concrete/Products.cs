using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dapper_MicroOrm_Example1.Entities.Concrete
{
    public class Products
    {
        public int CategoryID { get; set; }
        public decimal UnitPrice { get; set; }
        public string UnitsInStock { get; set; }


        public const string ConnectionString = "Server =DESKTOP-Q9BCSBK;Database=Northwind;Integrated Security=True;";
       public  void product(DataGridView datagridView)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                List<Products> Product = con.Query<Products>("Select * from Products Where Unitprice<=100 and  Unitprice>=10  Order By UnitPrice" ).ToList();
                datagridView.DataSource = Product;
                con.Close();
            }
        }
    }
}
   