namespace FlowModel.Model
{
    public class ReportUnitOfWork : UnitOfWork<ReportDbContext>
    {
        private Repository<Report, ReportDbContext> _reports;
     
        public ReportUnitOfWork(ReportDbContext context) : base(context)
        {
        }

        public IRepository<Report> Reports => _reports ?? (_reports = new Repository<Report, ReportDbContext>(Context));
    }
}