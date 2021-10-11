using EntityFramework_DbFirst_LİNQ.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFramework_DbFirst_LİNQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();
        private void btnTolist_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Shippers.ToList();
            dataGridView1.Columns[3].Visible = false;
        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products
                                       .Where(x => x.UnitPrice > 20 && x.UnitsInStock < 200)
                                       .ToList();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Order_Details
                                    .Where(x => x.UnitPrice >= 25 || x.Quantity > 100)
                                    .Select(x => new
                                    {
                                        x.OrderID, x.Quantity,
                                        x.UnitPrice
                                    })
                                    .ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Shippers
                                    .Where(x => x.ShipperID > 5 && x.ShipperID < 10)
                                    .Select(x => new
                                    {
                                        x.ShipperID,
                                        x.CompanyName,
                                        x.Phone
                                    })
                                    .OrderByDescending(x => x.CompanyName)
                                    .ToList();
        }

        private void btnorderby_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products
                                     .Where(x => x.UnitsInStock > 20)
                                     .Select(x => new
                                     {
                                         x.ProductID,
                                         x.UnitsInStock,
                                         x.UnitPrice
                                     })
                                     .OrderBy(x => x.UnitPrice)
                                     .ToList();


        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = db.Products.First(x => x.UnitPrice > 25);
                listBox1.Items.Add(product.ProductName);

            }
            catch (Exception)
            {

                MessageBox.Show("We dont find product ");
            }
        }

        private void btnfirst_default_Click(object sender, EventArgs e)
        {
            Category category = db.Categories.FirstOrDefault(x => x.CategoryID > 4);
            if (category == null)
                MessageBox.Show("Don't have category");
            else
                listBox1.Items.Add(category.CategoryName);
        }

        private void btnexample_7_Click(object sender, EventArgs e)
        {
            Product product = db.Products.Find(6);
            if (product == null)
                MessageBox.Show("dont have product");
            else
                MessageBox.Show($"Product Name: {product.ProductName}");
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products
                                     .Where(x => x.UnitPrice > 20 || x.UnitsInStock < 100)
                                     .Select(x => new
                                     {
                                         x.ProductID,
                                         x.ProductName,
                                         x.UnitPrice,
                                         x.UnitsInStock
                                     })
                                     .OrderBy(x => new
                                     {
                                         x.UnitPrice,
                                         x.UnitsInStock
                                     })
                                     .Take(3)
                                     .ToList();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products
                                    .Where(x => x.UnitPrice > 20 || x.UnitsInStock < 100)
                                    .Select(x => new
                                    {
                                        x.ProductID,
                                        x.ProductName,
                                        x.UnitPrice,
                                        x.UnitsInStock
                                    })
                                    .OrderBy(x => new
                                    {
                                        x.UnitPrice,
                                        x.UnitsInStock
                                    })
                                    .Skip(5)
                                    .Take(3)
                                    .ToList();
        }

        private void btnGroupBy_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products.GroupBy(x => x.Category.CategoryName)
                                                  .Select(x => new
                                                  {
                                                      Catogoryname = x.Key,
                                                      TotalyStock = x.Sum(z => z.UnitsInStock)
                                                  })
                                                  .ToList();
        }

        private void btnContai_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Order_Details
                             .Where(x => x.UnitPrice > 35 && x.Product.ProductName.Contains("S"))
                             .Select(x => new
                                  {
                                      x.OrderID,
                                      x.Quantity,
                                      x.Product.QuantityPerUnit
                                  })
                                .Take(10)
                                .Skip(3)
                                .OrderBy(x => x.Quantity)
                                .ToList();
        }

        private void btnStart_End_With_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Products
                                      .Where(x => x.ProductName.StartsWith("r") &&
                                               x.ProductName.EndsWith("t"))
                                      .OrderBy(x => x.ProductName)
                                      .ToList();

          
        
        }

        private void btnexample_12_Click(object sender, EventArgs e)
        {
            bool result = db.Categories.Any(x => x.CategoryName.StartsWith("Be"));
            MessageBox.Show(result.ToString());
        }

        private void btnexample_15_Click(object sender, EventArgs e)
        {
            decimal? expensiveProduct = db.Products.Max(x => x.UnitPrice);
            decimal? cheaperProduct = db.Products.Min(x => x.UnitPrice);
            Message.Show($"Expensive Product : {expensiveProduct} \nCheaper Product : {cheaperProduct}");
        }

        private void btnexample_13_Click(object sender, EventArgs e)
        {
            int ProductCount = db.Products.Count();
            MessageBox.Show("Product Count:" + ProductCount);
        }

        private void btnexample_14_Click(object sender, EventArgs e)
        {
            int? stokmiktari = db.Products.Sum(x => x.UnitsInStock);
            MessageBox.Show(stokmiktari.ToString());
        }

        private void btnexample_16_Click(object sender, EventArgs e)
        {
            List<string> countries = db.Employees.Select(x => x.Country).Distinct().ToList();
            foreach (var item in countries)
            {
                listBox1.Items.Add(item);
            }
        }
    }
}

