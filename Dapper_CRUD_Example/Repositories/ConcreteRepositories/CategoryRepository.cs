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
    public class CategoryRepository : IBaseRepository<Categories>
    {
        public void Create(Categories item, DataGridView dataGridView)
        {
            using (IDbConnection con = new SqlConnection("Server =DESKTOP-Q9BCSBK;Database=Northwind;Integrated Security=True;"))
            {
                con.Open();
                con.Execute("insert into categories (categoryName , Description) values (@categoryName , @Description);", 
                        ( new{ categoryName=item.CategoryName,      
                                Description=item.Description
                              }));
                List<Categories> category = con.Query<Categories>
                               ("Select * from Categories").ToList();
                dataGridView.DataSource = category;
                con.Close();
            }
        }

        public void Delete(Categories item, DataGridView dataGridView)
        {
            using (IDbConnection con = new SqlConnection("Server =DESKTOP-Q9BCSBK;Database=Northwind;Integrated Security=True;"))
            {
                con.Open();
                con.Execute("delete FROM Categories  WHERE CategoryID =@CategoryID;",
                              new { CategoryID = item.CategoryId});
                List<Categories> category = con.Query<Categories>
                                         ("Select * from Categories").ToList();
                dataGridView.DataSource = category;
                con.Close();

            }
        }

        public void GetActiveItems(DataGridView dataGridView)
        {
            {
                using (IDbConnection con = new SqlConnection("Server =DESKTOP-Q9BCSBK;Database=Northwind;Integrated Security=True;"))
                {
                    con.Open();
                    List<Categories> category = con.Query<Categories>
                                         ("Select * from Categories").ToList();
                    dataGridView.DataSource = category;
                    con.Close();
                }
            }
        }

        public void Update(Categories item, DataGridView dataGridView)
        {
            using (IDbConnection con = new SqlConnection("Server =DESKTOP-Q9BCSBK;Database=Northwind;Integrated Security=True;"))
            {
                con.Open();
                con.Execute("UPDATE Categories SET CategoryName = @CategoryName Description=@Description  WHERE CategoryID =@CategoryID;",
                            new { CAtegoryID = item.CategoryId, 
                                  CategoryName = item.CategoryName,   
                                  Description=item.Description });
                List<Categories> category = con.Query<Categories>
                                 ("Select * from Categories").ToList();
                dataGridView.DataSource = category;
                con.Close();
            }
        }
    }
}
        

       
      

      

       
  
