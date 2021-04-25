using System;
using System.Windows.Forms;
using FlowModel.Model.LoginService;
using FlowModel.Presenter;
using FlowModel.Presenter.ParentInterfaces;
using FlowModel.Presenter.Views;
using FlowModel.Presenter.Views.ReportView;
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
                .RegisterView<IReportView, ReportView>()
                .RegisterView<ILoginView, LoginView>()
                .RegisterService<ILoginService, LoginService>()
                .RegisterInstance(new ApplicationContext());

            DataBaseInitializer.Initialize();
            
            controller.Run<LoginPresenter>();
        }
    }
}