using FlowModel.Model;
using FlowModel.Presenter.ParentInterfaces;

namespace FlowModel.Presenter.Views.ChartView
{
    public class ChartPresenter : BasePresenter<IChartView, Graph>
    {
        private Graph _graph;
        
        public ChartPresenter(IApplicationController controller, IChartView view) : base(controller, view)
        {
            View.ChartName = _graph.Name;
            View.XAxisName = _graph.XAxisName;
            View.YAxisName = _graph.YAxisName;
            Draw();
        }

        public override void Run(Graph graph)
        {
            _graph = graph;
            View.Show();
        }

        private void Draw()
        {
            double[][] arr = new double[_graph.Series.Size][];
            for (var i = 0; i < _graph.Series.Size; i++)
            {
                arr[i] = new double[2];
                arr[i][0] = _graph.Series[i,0];
                arr[i][1] = _graph.Series[i,1];
            }
            View.DrawChart(arr);
        }
    }
}