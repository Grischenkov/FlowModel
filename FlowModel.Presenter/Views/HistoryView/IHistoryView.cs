using System;
using FlowModel.Presenter.ParentInterfaces;

namespace FlowModel.Presenter.Views.HistoryView
{
    public interface IHistoryView : IView
    {
        event Action SelectReport;
        void FillReportsRecords(string[][] records);
        string ReportId { get; set; }
        string ReportDate { get; set; }
        string ReportName { get; set; }
    }
}