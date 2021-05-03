using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace FlowModel.Model
{
    public class ReportDbContext : DbContext
    {
        public ReportDbContext() : base("ReportDbContext")
        {
        }

        public DbSet<Report> Reports { get; set; }
    }
}