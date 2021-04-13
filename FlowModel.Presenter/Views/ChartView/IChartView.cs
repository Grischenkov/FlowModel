using FlowModel.Presenter.ParentInterfaces;

namespace FlowModel.Presenter.Views.ChartView
{
    public interface IChartView : IView
    {
        string ChartName { set; }
        
        string XAxisName { set; }
        
        string YAxisName { set; }
        
        void DrawChart(double[][] table);
    }
}