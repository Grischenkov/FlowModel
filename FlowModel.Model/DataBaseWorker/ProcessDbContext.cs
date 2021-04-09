using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FlowModel.Model
{
    public class ProcessDbContext : DbContext
    {
        public ProcessDbContext() : base("ProcessDbContext")
        {
        }

        public DbSet<Unit> Units { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Parameter> Parameters { get; set; }
        public DbSet<MaterialParameters> MaterialParameters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}