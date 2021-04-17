using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FlowModel.Model
{
    public class UserDbContext : DbContext
    {
        public UserDbContext() : base("UserDbContext")
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}