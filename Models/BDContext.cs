using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ASP.Models
{
    public class BDContext : DbContext
    {
        public BDContext() : base("CafeDB")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Menu> MenuTab { get; set; }
    }
}