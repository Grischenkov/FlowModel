using System;
using System.IO;
using System.Linq;
using FlowModel.Model;
using FlowModel.Presenter.ParentInterfaces;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace FlowModel.Presenter.Views.HistoryView
{
    public class HistoryPresenter : BasePresenter<IHistoryView>
    {
        public HistoryPresenter(IApplicationController controller, IHistoryView view) : base(controller, view)
        {
            InitializeTable();
            View.SelectReport += () => ReportSelect();
        }

        private void ReportSelect()
        {
            Report report;
            using (var unitOfWork = new ReportUnitOfWork(new ReportDbContext()))
            {
                report = unitOfWork.Reports.Get(Convert.ToInt32(View.ReportId));
                if (report.Name != View.ReportName || report.DateTime.ToString("d").Replace("/", ".") != View.ReportDate)
                {
                    throw new Exception("Error");
                }
            }
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + report.Name + ".xlsx";
            File.WriteAllBytes(filePath, report.File);
            
            View.ShowSuccess("Отчет успешно скачан в папку " + '"' + "Документы" + '"' + '!');
        }
        
        private void InitializeTable()
        {
            using (var unitOfWork = new ReportUnitOfWork(new ReportDbContext()))
            {
                var reports = new string[unitOfWork.Reports.GetList().Count()][];
                var i = 0;
                foreach (var report in unitOfWork.Reports.GetList())
                {
                    reports[i] = new string[3];
                    reports[i][0] = report.Id.ToString();
                    reports[i][1] = report.DateTime.ToString("d");
                    reports[i][2] = report.Name;
                    i++;
                }
                View.FillReportsRecords(reports);
            }
        }
    }
}