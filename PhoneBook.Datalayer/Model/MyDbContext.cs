using PhoneBook.Datalayer.Entities.User;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PhoneBook.Datalayer.Model
{
    public class MyDbContext : DbContext
    {
    public MyDbContext() : base("Data Source=.;Initial Catalog=PhoneBook_DB;Integrated Security=true;")
        { 

        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<People> People { get; set; }
    }
}
