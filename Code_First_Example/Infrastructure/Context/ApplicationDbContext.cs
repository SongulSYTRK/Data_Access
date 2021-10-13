using Code_First_Example.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_Example.Infrastructure.Context
{
   public  class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext()
        {
            Database.Connection.ConnectionString = @"Server =DESKTOP-Q9BCSBK;Database=MyNortwindCodeFirst;Integrated Security=True;";
        }
        public DbSet<Shippers> Shipper { get; set; }

        public DbSet<Categories> Category { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Employees> Employess { get; set; }
        public DbSet<Order_Details> OrderDetails { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Suppliers> Suppliers { get; set; }
    }


}
