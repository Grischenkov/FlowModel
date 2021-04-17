using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowModel.Model;
using FlowModel.Presenter.ParentInterfaces;

namespace FlowModel.Presenter.Views.ReportView
{
    class ReportPresenter : BasePresenter<IReportView, ViewReport>
    {
        private ViewReport _report;
        
        public ReportPresenter(IApplicationController controller, IReportView view) : base(controller, view)
        {
        }

        public override void Run(ViewReport report)
        {
            _report = report;

            View.Time = _report.Time.ToString();
            View.Memory = _report.Memory.ToString();

            View.Performance = _report.Process.Channel.Performance.ToString();
            View.ResultTemperature = _report.Process.Channel.FlowingMaterial.ResultTemperature.ToString();
            View.ResultViscosity = _report.Process.Channel.FlowingMaterial.ResultViscosity.ToString();
            
            View.DrawResults(report.Process.Parameters.Table);
            View.Show();
        }
    }
}
