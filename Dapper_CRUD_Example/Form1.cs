using Dapper_CRUD_Example.Enums;
using Dapper_CRUD_Example.Repositories.ConcreteRepositories;
using Dapper_MicroOrm_Example1.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dapper_CRUD_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CategoryRepository categoryRepo = new CategoryRepository();
        ProductRepository productRepo = new ProductRepository();
        #region Products CRUD  
        private void btnCreateProduct_Click(object sender, EventArgs e)//İnsert
        {
            Products product = new Products();
            productRepo.Create(product, dataGridView1);
            product.ProductName = txtProductName.Text;
            product.UnitPrice =int.Parse( txtUnitpriceProduct.Text);
            product.UnitsInStock = int.Parse(txtunitInStockCreate.Text);
            productRepo.Create(product, dataGridView1);
            product.CreateDate = DateTime.Now;

        }

        private void button1_Click(object sender, EventArgs e)//Delete
        {
            Products product = new Products();            
            product.ProductID = int.Parse(txtId.Text);
            productRepo.Delete(product, dataGridView1);
            product.Status = Status.Passive;
          
         

        }

        private void button2_Click(object sender, EventArgs e)//Listele
        {
            Products product = new Products();
            productRepo.GetActiveItems(dataGridView1);
        }
        private void button1_Click_1(object sender, EventArgs e)//Update
        {
            Products product = new Products();
           
            product.ProductID=int.Parse(txtId.Text);
            product.ProductName = txtNameUpdatePRoduct.Text;
            product.UnitPrice = int.Parse(txtUnitpriceProduct.Text);
            product.UnitsInStock = int.Parse(txtUnitstockUpdateProduct.Text);
            productRepo.Update(product, dataGridView1);
            product.Status = Status.Modified;
        }
        #endregion
        #region Categories CRUD
        private void button3_Click(object sender, EventArgs e)//Listele
        {
           Categories categories = new Categories();
           categoryRepo.GetActiveItems(dataGridView1);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            categories.CategoryName = txtCategoryName.Text;
            categories.Description = txtDescription.Text;
            categoryRepo.Create(categories, dataGridView1);
            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            
            categories.CategoryId = int.Parse(txtCatgoryID.Text);
            categoryRepo.Delete(categories, dataGridView1);
            categories.Status = Status.Passive;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            categoryRepo.Update(categories, dataGridView1);
            categories.CategoryId = int.Parse(txtCatgoryID.Text);
            categories.CategoryName = txtCategoryName.Text;
            categories.Description = txtDescription.Text;
            categoryRepo.Update(categories, dataGridView1);
            categories.Status = Status.Passive;

        }
        #endregion
    }
}
