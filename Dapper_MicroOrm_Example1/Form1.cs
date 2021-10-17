using Dapper;
using Dapper_MicroOrm_Example1.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dapper_MicroOrm_Example1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            Categories category = new Categories();
            category.ctg(dataGridView1);
        }

        private void btnproduct_Click(object sender, EventArgs e)
        {
            Products Product = new Products();
            Product.product(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (IDbConnection con = new SqlConnection("Server =DESKTOP-Q9BCSBK;Database=Northwind;Integrated Security=True;"))
            {
                con.Open();
                List<Categories> category = con.Query<Categories>("Select *  from Categories Where CategoryName='Baklagiller' or CategoryId=4 Order By  CategoryName Desc").ToList();
                dataGridView1.DataSource = category;
                con.Close();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            using (IDbConnection con = new SqlConnection("Server =DESKTOP-Q9BCSBK;Database=Northwind;Integrated Security=True;"))
            {
                con.Open();

                dataGridView1.DataSource = con.Query<Employees>("select Top 2 * from Employees where YEAR( BirthDate) between 1952 and 1960  order by FirstName asc ").ToList();

                con.Close();
            }
        }

        private void btnLike_Click(object sender, EventArgs e)
        {

            using (IDbConnection con = new SqlConnection("Server =DESKTOP-Q9BCSBK;Database=Northwind;Integrated Security=True;"))
            {
                con.Open();

                dataGridView1.DataSource = con.Query<Employees>(" select * from Employees where FirstName Like 'A%' order by Lastname desc ").ToList();

                con.Close();
            }
        }

        private void btnContain_Click(object sender, EventArgs e)
        {
            using (IDbConnection con = new SqlConnection("Server =DESKTOP-Q9BCSBK;Database=Northwind;Integrated Security=True;"))
            {
                con.Open();

                dataGridView1.DataSource = con.Query<Employees>(" select * from Employees where FirstName Like '%A%' order by Firstname asc ").ToList();

                con.Close();
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            using (IDbConnection con = new SqlConnection("Server =DESKTOP-Q9BCSBK;Database=Northwind;Integrated Security=True;"))
            {
                con.Open();
                var query = "select COUNT(UnitPrice) as [Total price ] from Products ";
                var Count = con.Query(query);
                dataGridView1.DataSource = Count;

                con.Close();
            }
        }
        private void btnFirstOrdeFault_Click(object sender, EventArgs e)
        {
            using (IDbConnection con = new SqlConnection("Server =DESKTOP-Q9BCSBK;Database=Northwind;Integrated Security=True;"))
            {
                con.Open();
                var query = "Select * From Products Where ProductId > @ProductId";
                var result = con.QueryFirstOrDefault(query, new { ProductId = 104 });
                MessageBox.Show($"{result}");
                //listBox1.Items.Add(result);
                con.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (IDbConnection con = new SqlConnection("Server =DESKTOP-Q9BCSBK;Database=Northwind;Integrated Security=True;"))
            {
                try
                {
                    con.Open();
                    var query = "Select * From Products Where ProductId > @ProductId";
                    var result = con.QueryFirst(query, new { ProductId = 14 }); MessageBox.Show($"{result}");
                    //listBox1.Items.Add(result);
                    con.Close();
                }
                catch (Exception)
                {

                    MessageBox.Show($"dont have result ");
                }

            }

        }
        private void btnSingleOrDefault_Click(object sender, EventArgs e)
        {
            using (IDbConnection con = new SqlConnection("Server =DESKTOP-Q9BCSBK;Database=Northwind;Integrated Security=True;"))
            {
                con.Open();
                var query = "Select * From Products Where ProductId = @ProductId";
                var result = con.QuerySingleOrDefault(query, new { ProductId = 14 });
                //var result = con.QuerySingle(query, new { ProductId = 4 });
                MessageBox.Show($"{result}");
                //listBox1.Items.Add(result);
                con.Close();
            }
        }

        private void btnQuarySingle_Click(object sender, EventArgs e)
        {
            using (IDbConnection con = new SqlConnection("Server =DESKTOP-Q9BCSBK;Database=Northwind;Integrated Security=True;"))
            {
                try
                {
                    con.Open();
                    var query = "Select * From Products Where ProductId = @ProductId";
                    var result = con.QuerySingle(query, new { ProductId = 104 });
                    MessageBox.Show($"{result}");
                    //listBox1.Items.Add(result);
                    con.Close();

                }
                catch (Exception)
                {

                    MessageBox.Show($"don't have result");
                }

            }

        }

        private void btnQueryMultiple_Click(object sender, EventArgs e)
        {
            using (IDbConnection con = new SqlConnection("Server =DESKTOP-Q9BCSBK;Database=Northwind;Integrated Security=True;"))
            {
                con.Open();

                var sql = "Select * From Products where UnitPrice >50 order by ProductName ;" +
                          " Select * From Categories where CategoryID > 6 order by CategoryName Desc";

                var multiQuery = con.QueryMultiple(sql);
                var productList = multiQuery.Read<Products>().ToList();
                var categoryList = multiQuery.Read<Categories>().ToList();
                dataGridView1.DataSource = productList;
                dataGridView2.DataSource = categoryList;

                con.Close();
            }

        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            using (IDbConnection con = new SqlConnection("Server =DESKTOP-Q9BCSBK;Database=Northwind;Integrated Security=True;"))
            {
                //Example 1 - Join
                con.Open();

                dataGridView1.DataSource = con.Query("select * from categories as c inner join products p on c.categoryId=p.categoryId ").ToList();

                con.Close();

                //Example 2-Join 
                con.Open();

                dataGridView2.DataSource = con.Query("select  sum( p.UnitsInStock) as [Totaly Stock], c.CategoryName from Categories c join Products p on c.CategoryID=p.CategoryID group by c.CategoryName order by 1 ").ToList();

                con.Close();
            }
        }

        private void btnStoreProcedure_Example_Click(object sender, EventArgs e)
        {
            using (IDbConnection con = new SqlConnection("Server =DESKTOP-Q9BCSBK;Database=Northwind;Integrated Security=True;"))
            {
                //Example 1-Store Procedure
                Categories category = new Categories();
                con.Open();
                var procedure1 = "[sp_urunbycategory]";
                var value1 = new { @id = "8" };
                dataGridView1.DataSource = con.Query(procedure1, value1, commandType: CommandType.StoredProcedure).ToList();

                con.Close();
                //Example 2-StoreProssedure 
                Employees employee = new Employees();
                con.Open();
                var procedure2 = "[sp_adsoyad]";
                var value2 = new { @ad = "King", @soyad = "Robert" };
                dataGridView1.DataSource = con.Query(procedure2, value2, commandType: CommandType.StoredProcedure).ToList();

            }

        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            using (IDbConnection con = new SqlConnection("Server =DESKTOP-Q9BCSBK;Database=Northwind;Integrated Security=True;"))
            {
                con.Open();

                dataGridView2.DataSource = con.Query("select SUM(UnitPrice) as [Total price ] from Products ").ToList();

                con.Close();
            }

        }

        private void btnGorupby_Click(object sender, EventArgs e)
        {
            using (IDbConnection con = new SqlConnection("Server =DESKTOP-Q9BCSBK;Database=Northwind;Integrated Security=True;"))

            //Example 1- 
            {
                con.Open();

                dataGridView2.DataSource = con.Query(" select country, count(*) as [Totaly Employes ] from Employees where country is not null group by Country order by 2 desc ").ToList();

                con.Close();
            }

            //Example2-
            {
                con.Open();

                dataGridView1.DataSource = con.Query(" select CategoryID, COUNT(*) as [Stock Count]  from Products where ( UnitsInStock between 5 AND 50 ) and  ( Productname  like '[A-K]%') group by CategoryID ").ToList();

                con.Close();
            }
        }
    }
}
