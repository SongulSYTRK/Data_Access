using Dapper;
using Dapper_CRUD_Example.Repositories.BaseRepositories;
using Dapper_MicroOrm_Example1.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dapper_CRUD_Example.Repositories.ConcreteRepositories
{


    public class ProductRepository : IBaseRepository<Products>
    {


        public void Create(Products item, DataGridView dataGridView)

        {
            using (IDbConnection con = new SqlConnection("Server =DESKTOP-Q9BCSBK;Database=Northwind;Integrated Security=True;"))
            {
                con.Open();
                con.Execute("INSERT INTO Products (ProductName , UnitPrice , UnitInStock) Values (@ProductName, @UnitPrice , @UnitInStock);",(new { ProductName =item.ProductName, UnitPrice =item.UnitPrice, UnitInStock = item.UnitsInStock } ));  // Bu kod hata veriyor çalışmıyor hocaya sor?!!!

                //con.Execute("INSERT INTO Products (ProductName) Values (@ProductName );", new[] { new { @ProductName = item.ProductName}, new { @ProductName = item.ProductName}, new { @ProductName = item.ProductName} });  //=>Multiple Added 

                // con.Execute("INSERT INTO Products (ProductName) Values (@ProductName );", new { @ProductName =item.ProductName } );  => Single Added 


                List<Products> product = con.Query<Products>("Select * from Products").ToList();

                dataGridView.DataSource = product;
                con.Close();
            }
        }
       
        public void Delete(Products item, DataGridView dataGridView)
        {
            using (IDbConnection con = new SqlConnection("Server =DESKTOP-Q9BCSBK;Database=Northwind;Integrated Security=True;"))
            {
                con.Open();
                con.Execute("delete FROM Products  WHERE ProductID =@ProductID;",new {ProductID=item.ProductID } );
                List<Products> product = con.Query<Products>("Select * from Products").ToList();
                dataGridView.DataSource = product;
                con.Close();

            }
        }
       
        public void GetActiveItems(DataGridView dataGridView)
            {
            using (IDbConnection con = new SqlConnection("Server =DESKTOP-Q9BCSBK;Database=Northwind;Integrated Security=True;"))
            {
                con.Open();
                List<Products> product = con.Query<Products>("Select * from Products").ToList();
                dataGridView.DataSource = product;
                con.Close();
            }


        }
        
        public void Update(Products item,DataGridView dataGridView)
            {
            using (IDbConnection con = new SqlConnection("Server =DESKTOP-Q9BCSBK;Database=Northwind;Integrated Security=True;"))
            {
                con.Open();

                con.Execute("UPDATE Products SET ProductName = @ProductName  WHERE ProductID =@ProductID;" , new { ProductID=item.ProductID, ProductName = item.ProductName });

                List<Products> product = con.Query<Products>("Select * from Products").ToList();

                dataGridView.DataSource = product;

                con.Close();

            }
        }
        
    }
}

