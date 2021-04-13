using System;
using System.Windows.Forms;
using FlowModel.Presenter;
using FlowModel.Presenter.ParentInterfaces;
using FlowModel.Presenter.Views.ChartView;
using FlowModel.Presenter.Views.ResearcherView;

namespace FlowModel
{
    internal static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IApplicationController controller = new ApplicationController(new LightInjectAdapter())
                .RegisterView<IResearcherView, ResearcherView>()
                .RegisterView<IDataTableView, DataTableView>()
                .RegisterView<IChartView, ChartView>()
                .RegisterInstance(new ApplicationContext());

            controller.Run<ResearcherPresenter>();
        }
    }
}