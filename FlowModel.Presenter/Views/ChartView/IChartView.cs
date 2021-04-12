using FlowModel.Presenter.ParentInterfaces;

namespace FlowModel.Presenter.Views.ChartView
{
    public interface IChartView : IView
    {
        string ChartName { get; set; }
        
        string XAxisName { get; set; }
        
        string YAxisName { get; set; }
    }
}