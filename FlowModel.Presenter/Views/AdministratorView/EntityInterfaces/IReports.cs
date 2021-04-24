using System;

namespace FlowModel.Presenter.Views.AdministratorView.EntityInterfaces
{
    public interface IReports
    {
        void FillReportsRecords(string[][] records);
        string ReportId { set; }
        string ReportDate { set; }
        string ReportName { set; }
        event Action DeleteReport;
    }
}