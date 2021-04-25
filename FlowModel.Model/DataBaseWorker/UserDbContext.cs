using System.Data.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Infrastructure;

namespace FlowModel.Model
{
    public class UserDbContext : DbContext
    {
        public UserDbContext() : base("UserDbContext")
        {
        }

        public DbSet<User> Users { get; set; }
    }
}