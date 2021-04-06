using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FlowModel.Model
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext() : base("DataBaseContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<Parameter> Parameters { get; set; }
        public DbSet<Coefficient> Coefficients { get; set; }
        public DbSet<MaterialParameters> MaterialParameters { get; set; }
        public DbSet<MaterialCoefficients> MaterialCoefficients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}