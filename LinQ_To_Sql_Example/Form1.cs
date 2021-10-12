using LinQ_To_Sql_Example.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinQ_To_Sql_Example
{
    public partial class Form1 : Form
    {
        NorthwindEntities db;
        public Form1()
        {
            db = new NorthwindEntities();
            InitializeComponent();
        }

        private void btnExample_1_Click(object sender, EventArgs e)
        {
            #region linq To Entity 
            dataGridView1.DataSource = db.Employees
                                       .Select(x => new
                                         {
                                             Fulname = x.FirstName + " " + x.LastName,
                                             x.Title,
                                             x.BirthDate
                                         })
                                         .ToList();
            #endregion

            #region linq To SQL
            var employees = from x in db.Employees
                            select new
                            {
                                x.FirstName,
                                x.LastName,
                                x.Title,
                                x.BirthDate
                            };
            dataGridView1.DataSource = employees.ToList();

            #endregion
        }

        private void btnExample_2_Click(object sender, EventArgs e)
        {
            #region linq To SQL
            var product = from x in db.Products
                            where x.ProductID > 2 && x.ProductID < 8
                            orderby x.ProductName
                            select new
                            {
                                x.ProductID,
                                x.ProductName,
                                x.UnitsInStock
                            };
            dataGridView1.DataSource = product.ToList();
            #endregion

        }

        private void btnexample_3_Click(object sender, EventArgs e)
        {
            #region linq To SQL

            var orderdetails = from od in db.Order_Details
                               orderby od.Quantity * od.UnitPrice * (int)Math.Floor(1 - od.Discount)
                               group od by od.OrderID into kyw
                               select new
                               {
                                   OrderId = kyw.Key,
                                   Total = kyw.Sum(x => x.Quantity * x.UnitPrice * (int)Math.Floor(1 - x.Discount))
                               };
            dataGridView1.DataSource = orderdetails.ToList();

            #endregion
        }

        private void btnExample_4_Click(object sender, EventArgs e)
        {
            #region linQ to SQL
            var employee = from x in db.Employees
                           where x.TitleOfCourtesy == "Mr." && SqlFunctions.DateDiff("Year", x.BirthDate, DateTime.Now) > 40
                           orderby SqlFunctions.DateDiff("Year", x.BirthDate, DateTime.Now)
                           select new
                           {
                               x.TitleOfCourtesy,
                               x.FirstName,
                               x.LastName,
                               Age = SqlFunctions.DateDiff("Year", x.BirthDate, DateTime.Now)
                           };
            dataGridView1.DataSource = employee.ToList();

            #endregion
        }
    }
}
