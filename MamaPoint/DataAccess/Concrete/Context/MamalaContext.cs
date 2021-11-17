using Entities;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Context
{
    public class MamalaContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<FoodContainer> FoodContainers { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Supporter> Supporters { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
