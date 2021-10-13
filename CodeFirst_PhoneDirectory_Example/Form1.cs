using CodeFirst_PhoneDirectory_Example.Infrastructure.Context;
using CodeFirst_PhoneDirectory_Example.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst_PhoneDirectory_Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ApplicationDbContext db = new ApplicationDbContext();
        private void btnInsert_Click(object sender, EventArgs e)
        {
           PhoneDirectory Directory = new PhoneDirectory();

           Directory.Name = txtname.Text;
           Directory.PhoneNumber =int.Parse(txtphonenumber.Text);

           db.Phone_Directory.Add(Directory);
           db.SaveChanges();
           dataGridView1.DataSource = db.Phone_Directory.ToList();
           Utility.Eraser(grpPhoneDirectory);
        }
    }
}
