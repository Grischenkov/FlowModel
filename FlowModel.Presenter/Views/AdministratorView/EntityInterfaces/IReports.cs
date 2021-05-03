using System;

namespace FlowModel.Presenter.Views.AdministratorView.EntityInterfaces
{
    public interface IReports
    {
        void FillReportsRecords(string[][] records);
        string ReportId { get; set; }
        string ReportDate { get; set; }
        string ReportName { get; set; }
        event Action DeleteReport;
    }
}