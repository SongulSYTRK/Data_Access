using CodeFirst_PhoneDirectory_Example.Models.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_PhoneDirectory_Example.Infrastructure.Context
{
   public  class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext()
        {
            Database.Connection.ConnectionString = @"Server =DESKTOP-Q9BCSBK;Database=TelephoneDirectory;Integrated Security=True;";
        }
        public DbSet<PhoneDirectory> Phone_Directory { get; set; }
    }
}
