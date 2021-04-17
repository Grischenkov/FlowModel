using System.Windows.Forms.DataVisualization.Charting;
using FlowModel.Presenter.ParentInterfaces;

namespace FlowModel.Presenter.Views.ReportView
{
    public interface IReportView : IView
    {
        string Time { set; }
        string Memory { set; }
        
        string Performance { set; }
        string ResultTemperature { set; }
        string ResultViscosity { set; }
        
        void DrawResults(double[][] results);
    }
}
