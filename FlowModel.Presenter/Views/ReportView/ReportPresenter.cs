using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FlowModel.Model;
using FlowModel.Presenter.ParentInterfaces;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
using Type = System.Type;

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

            View.Export += Export;
        }

        private void Export()
        {
            SaveFileDialog saveFile = new SaveFileDialog
            {
                Title = "Export data to excel...",
                Filter = "Excel files(*.xlsx)|*.xlsx",
                OverwritePrompt = true,
                CheckPathExists = true
            };

            DialogResult check = saveFile.ShowDialog();

            switch (check)
            {
                case DialogResult.OK:
                {
                    string filePath = saveFile.FileName;

                    Application excel = new Application();
                    excel.DisplayAlerts = false;
                    Workbook workbook = Excel.GenerateWorkbook(ref excel, _report);
                    
                    workbook.SaveAs(filePath);
                    try
                    {
                        workbook.Close();
                        excel.Quit();
                    }
                    catch (Exception)
                    {
                        // ignored
                    }
                    View.ShowSuccess("Отчет сохранен!");
                    break;
                }
                case DialogResult.Cancel:
                    break;
                default:
                    throw new Exception("Error exporting data!");
            }
        }
    }
}
