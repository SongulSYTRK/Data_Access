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

                dataGridView1.DataSource = con.Query<Employees>(" select * from Employees where FirstName Like 'A%' order by Lastname desc " ).ToList();

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

        private void btnGroupBy_Click(object sender, EventArgs e)
        {

            using (IDbConnection con = new SqlConnection("Server =DESKTOP-Q9BCSBK;Database=Northwind;Integrated Security=True;"))
            {
                con.Open();

                dataGridView1.DataSource = con.Query<Products>(" select COUNT(UnitPrice) from Products where UnitPrice < 35 group by CategoryID ").ToList();

                con.Close();
            }

        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            using (IDbConnection con = new SqlConnection("Server =DESKTOP-Q9BCSBK;Database=Northwind;Integrated Security=True;"))
            {
                con.Open();
                var query = " select COUNT(UnitPrice) from Products where UnitPrice < 35  ";
                var Count = con.Query<Products>(query);
                MessageBox.Show($" {Count}");

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
                    var result = con.QueryFirst(query,new { ProductId=14 });          MessageBox.Show($"{result}");
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
                var result = con.QuerySingleOrDefault(query, new { ProductId =14 });
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

        
    }
}
