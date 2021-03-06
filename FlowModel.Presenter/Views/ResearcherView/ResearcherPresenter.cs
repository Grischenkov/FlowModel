using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlowModel.Model;
using FlowModel.Presenter.ParentInterfaces;
using FlowModel.Presenter.Views.AboutView;
using FlowModel.Presenter.Views.HistoryView;
using FlowModel.Presenter.Views.ReportView;
using Process = FlowModel.Model.Process;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
using Chart = Microsoft.Office.Interop.Excel.Chart;
using Series = Microsoft.Office.Interop.Excel.Series;
using SeriesCollection = Microsoft.Office.Interop.Excel.SeriesCollection;
using Type = System.Type;


namespace FlowModel.Presenter.Views.ResearcherView
{
    public class ResearcherPresenter : BasePresenter<IResearcherView>
    {
        private long _memory;

        private Process _process;

        private ViewReport _report;

        private readonly ProcessUnitOfWork _unitOfWork;

        private Stopwatch _time;

        public ResearcherPresenter(IApplicationController controller, IResearcherView view) : base(controller, view)
        {
            _process = new Process();

            _unitOfWork = new ProcessUnitOfWork(new ProcessDbContext());

            foreach (var material in _unitOfWork.Materials.GetList())
            {
                View.MaterialItem = material.Name;
            }

            View.SelectMaterial += SelectMaterial;

            View.Calculate += Calculate;

            View.Open += Open;
            View.Save += Save;
            View.Export += Export;
            View.Logout += Logout;
            View.Exit += Exit;

            View.Settings += Settings;
            View.Help += Help;
            View.About += About;
        }


        private void Logout()
        {
            Controller.Run<LoginPresenter>();
            View.Close();
        }
        
        private void SelectMaterial()
        {
            var material = _unitOfWork.Materials.GetList().First(x => x.Name == View.MaterialSelectedItem);

            View.Density.Value = _unitOfWork.MaterialParameters.GetList()
                .First(x => x.MaterialId == material.Id && x.Parameter.Name == "Плотность").ParameterValue.ToString();
            View.HeatCapacity.Value = _unitOfWork.MaterialParameters.GetList()
                .First(x => x.MaterialId == material.Id && x.Parameter.Name == "Теплоемкость").ParameterValue
                .ToString();
            View.MeltingTemperature.Value = _unitOfWork.MaterialParameters.GetList()
                .First(x => x.MaterialId == material.Id && x.Parameter.Name == "Температура плавления").ParameterValue
                .ToString();

            View.ConsistencyIndex.Value = _unitOfWork.MaterialParameters.GetList().First(x =>
                x.MaterialId == material.Id &&
                x.Parameter.Name == "Коэффициент консистенции при температуре приведения").ParameterValue.ToString();
            View.ViscosityIndex.Value = _unitOfWork.MaterialParameters.GetList().First(x =>
                    x.MaterialId == material.Id && x.Parameter.Name == "Температурный коэффициент вязкости")
                .ParameterValue
                .ToString();
            View.ReferenceTemperature.Value = _unitOfWork.MaterialParameters.GetList()
                .First(x => x.MaterialId == material.Id && x.Parameter.Name == "Температура приведения").ParameterValue
                .ToString();
            View.FlowIndex.Value = _unitOfWork.MaterialParameters.GetList()
                .First(x => x.MaterialId == material.Id && x.Parameter.Name == "Индекс течения").ParameterValue
                .ToString();
            View.HeatTransferIndex.Value = _unitOfWork.MaterialParameters.GetList().First(x =>
                x.MaterialId == material.Id &&
                x.Parameter.Name == "Коэффициент теплоотдачи от крышки канала к материалу").ParameterValue.ToString();
        }

        private void Calculation()
        {
            _time = new Stopwatch();
            _time.Start();
            var startMemory = GC.GetAllocatedBytesForCurrentThread();

            var cap = new Cap(Convert.ToDouble(View.LidTemperature.Value), Convert.ToDouble(View.LidSpeed.Value));

            var flowingMaterial = new FlowingMaterial(Convert.ToDouble(View.MeltingTemperature.Value),
                Convert.ToDouble(View.HeatCapacity.Value), Convert.ToDouble(View.ReferenceTemperature.Value),
                Convert.ToDouble(View.ViscosityIndex.Value), Convert.ToDouble(View.HeatTransferIndex.Value),
                Convert.ToDouble(View.ConsistencyIndex.Value), Convert.ToDouble(View.FlowIndex.Value),
                Convert.ToDouble(View.Density.Value));

            var channel = new Channel(Convert.ToDouble(View.Width.Value), Convert.ToDouble(View.Depth.Value),
                Convert.ToDouble(View.Length.Value), Convert.ToDouble(View.Step.Value), cap, flowingMaterial);

            _process = new Process(channel);

            var endMemory = GC.GetAllocatedBytesForCurrentThread();
            _memory = endMemory - startMemory;
            _time.Stop();

            _report = new ViewReport(_process, _memory, _time.ElapsedMilliseconds);
            
            //Export(DateTime.Now);
            Task expot = Task.Run(()=>Export(DateTime.Now));
        }

        private void Calculate()
        {
            ParametersCheck();

            Task calculation = Task.Run(Calculation);
            View.IsProcessing = true;
            calculation.Wait();
            View.IsProcessing = false;

            Controller.Run<ReportPresenter, ViewReport>(_report);
        }

        private void ParametersCheck()
        {
            ValueCheck(View.Width);
            ValueCheck(View.Depth);
            ValueCheck(View.Length);

            ValueCheck(View.Density);
            ValueCheck(View.HeatCapacity);
            ValueCheck(View.MeltingTemperature);

            ValueCheck(View.LidTemperature);
            ValueCheck(View.LidSpeed);

            ValueCheck(View.Step);

            ValueCheck(View.FlowIndex);
            ValueCheck(View.ViscosityIndex);
            ValueCheck(View.ConsistencyIndex);
            ValueCheck(View.HeatTransferIndex);
            ValueCheck(View.ReferenceTemperature);

            if (!(Convert.ToDouble(View.Length.Value) / Convert.ToDouble(View.Step.Value) > 5000)) return;
            View.Step.Value = (Convert.ToDouble(View.Length.Value) / 5000).ToString();
            throw new ArgumentException("Количество шагов не может привышать 5000. Значение шага увеличено.",
                View.Step.ParameterName);
        }

        private void ValueCheck(IParameterInput parameter)
        {
            if (!string.IsNullOrEmpty(parameter.Value))
            {
                try
                {
                    Convert.ToDouble(parameter.Value);
                }
                catch (Exception e)
                {
                    parameter.IsIncorrect = true;
                    throw new ArgumentException("Недопустимый формат параметра: " + parameter.ParameterName);
                }

                if (Convert.ToDouble(parameter.Value) < 0.001)
                {
                    throw new ArgumentException("Параметр не может быть меньше 0,001:" + parameter.ParameterName);
                }
            }
            else
            {
                parameter.IsIncorrect = true;
                throw new ArgumentNullException(parameter.ParameterName);
            }
        }

        private void Open()
        {
            Controller.Run<HistoryPresenter>();
        }

        private void Save()
        {
            //TODO Implement saving functionality            
        }

        private void Export()
        {
            if (_report == null) throw new Exception("Calculate process parameters before exporting!");
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
        
        private void Export(DateTime dateTime)
        {
            string str = "Report_" + View.MaterialItem.Replace(' ', '_') + "_" + dateTime.Year + "-" + dateTime.Month + "-" +
                         dateTime.Day + "-" + dateTime.Hour + "-" + dateTime.Minute + "-" + dateTime.Second;
            string filePath = Directory.GetCurrentDirectory() + "\\" + str;

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

            byte[] rep = File.ReadAllBytes(filePath + ".xlsx");
            using (var unit = new ReportUnitOfWork(new ReportDbContext()))
            {
                int maxId = 1;
                try
                {
                    maxId = unit.Reports.GetList().Max(x => x.Id) + 1;
                }
                catch (Exception e)
                {
                    // ignored
                }


                unit.Reports.Insert(new Report
                {
                    Id = maxId,
                    Name = str,
                    DateTime = dateTime,
                    File = rep
                });
                
                unit.Commit();
            }
            File.Delete(filePath + ".xlsx");
        }

        private void Settings()
        {
            //Controller.Run<SettingsPresenter>();
        }

        private void Help()
        {
            //Controller.Run<HelpPresenter>();
        }

        private void About()
        {
            Controller.Run<AboutPresenter>();
        }
    }
}