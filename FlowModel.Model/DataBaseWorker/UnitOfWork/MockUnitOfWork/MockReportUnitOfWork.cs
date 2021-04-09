namespace FlowModel.Model
{
    public class MockReportUnitOfWork : UnitOfWork
    {
        private MockRepository<Report> _reports;

        public IRepository<Report> Reports => _reports ?? (_reports = new MockRepository<Report>());
    }
}