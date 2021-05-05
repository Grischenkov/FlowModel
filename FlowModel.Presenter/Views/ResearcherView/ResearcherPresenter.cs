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
            View.Exit += Exit;

            View.Settings += Settings;
            View.Help += Help;
            View.About += About;
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
            
            Export(DateTime.Now);
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
            //TODO Implement loading functionality
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
                    Workbook workbook = GenerateWorkbook(ref excel);

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
            string str = "Report_" + dateTime.Year + "-" + dateTime.Month + "-" +
                         dateTime.Day + "-" + dateTime.Hour + "-" + dateTime.Minute + "-" + dateTime.Second;
            string filePath = Directory.GetCurrentDirectory() + "\\" + str;

            Application excel = new Application();
            Workbook workbook = GenerateWorkbook(ref excel);

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
                    Name = filePath,
                    DateTime = dateTime,
                    File = rep
                });
                
                unit.Commit();
            }
            File.Delete(filePath + ".xlsx");
            View.ShowSuccess("Отчет сохранен в базе данных!");
        }
        
        private Workbook GenerateWorkbook(ref Application excel)
        {
            Workbook workbook = excel.Workbooks.Add();
            Worksheet worksheet = workbook.ActiveSheet;

            excel.Visible = false;
            int size = 1;
            
            worksheet.Columns[1].ColumnWidth = 15;
            worksheet.Columns[2].ColumnWidth = 15;
            worksheet.Columns[3].ColumnWidth = 15;
            worksheet.Columns[17].ColumnWidth = 47;

            worksheet.Rows[1].Columns[1] = "Координата, м";
            worksheet.Rows[1].Columns[2] = "Температура, °C";
            worksheet.Rows[1].Columns[3] = "Вязкость, Па⋅с";
            worksheet.Cells[1, 1].Font.Bold = true;
            worksheet.Cells[1, 2].Font.Bold = true;
            worksheet.Cells[1, 3].Font.Bold = true;

            for (int i = 0, j = 1; i < _report.Process.Parameters.Table.Length; i++, j++, size++)
            {
                worksheet.Rows[j + 1].Columns[1] = _report.Process.Parameters.Table[i][0];
                worksheet.Rows[j + 1].Columns[2] = _report.Process.Parameters.Table[i][1];
                worksheet.Rows[j + 1].Columns[3] = _report.Process.Parameters.Table[i][2];
            }
            
            worksheet.Cells[1, 17].Font.Bold = true;
            worksheet.Rows[1].Columns[17] = "Результаты расчета"; 
            worksheet.Rows[2].Columns[17] = "Производительность [кг/ч]"; 
            worksheet.Rows[2].Columns[18] = _report.Process.Channel.Performance;
            worksheet.Rows[3].Columns[17] = "Вязкость [Па⋅с]"; 
            worksheet.Rows[3].Columns[18] = _report.Process.Channel.FlowingMaterial.ResultViscosity;
            worksheet.Rows[4].Columns[17] = "Температура [°C]"; 
            worksheet.Rows[4].Columns[18] = _report.Process.Channel.FlowingMaterial.ResultTemperature;
            worksheet.Rows[5].Columns[17] = "Время работы [мс]"; 
            worksheet.Rows[5].Columns[18] = _report.Time;
            worksheet.Rows[6].Columns[17] = "Оперативная память [Кб]"; 
            worksheet.Rows[6].Columns[18] = _report.Memory;

            
            worksheet.Cells[8, 17].Font.Bold = true;
            worksheet.Rows[8].Columns[17] = "Геометрические параметры канала"; 
            worksheet.Rows[9].Columns[17] = "Ширина [м]"; 
            worksheet.Rows[9].Columns[18] = _report.Process.Channel.Width;
            worksheet.Rows[10].Columns[17] = "Глубина [м]"; 
            worksheet.Rows[10].Columns[18] = _report.Process.Channel.Depth;
            worksheet.Rows[11].Columns[17] = "Длина [м]"; 
            worksheet.Rows[11].Columns[18] = _report.Process.Channel.Depth;
            
            worksheet.Cells[13, 17].Font.Bold = true;
            worksheet.Rows[13].Columns[17] = "Параметры свойств материала"; 
            worksheet.Rows[14].Columns[17] = "Плотность [кг/м^3]"; 
            worksheet.Rows[14].Columns[18] = _report.Process.Channel.FlowingMaterial.Density;
            worksheet.Rows[15].Columns[17] = "Удельная теплоемкость [Дж/(кг⋅°C)]"; 
            worksheet.Rows[15].Columns[18] = _report.Process.Channel.FlowingMaterial.HeatCapacity;
            worksheet.Rows[16].Columns[17] = "Температура плавления [°C]"; 
            worksheet.Rows[16].Columns[18] = _report.Process.Channel.FlowingMaterial.MeltingTemperature;
            
            worksheet.Cells[18, 17].Font.Bold = true;
            worksheet.Rows[18].Columns[17] = "Режимные параметры процесса"; 
            worksheet.Rows[19].Columns[17] = "Скорость крышки [м/с]";
            worksheet.Rows[19].Columns[18] = _report.Process.Channel.Cap.Speed;
            worksheet.Rows[20].Columns[17] = "Температура крышки [°C]";
            worksheet.Rows[20].Columns[18] = _report.Process.Channel.Cap.Temperature;
            
            worksheet.Cells[22, 17].Font.Bold = true;
            worksheet.Rows[22].Columns[17] = "Коэффициенты математической модели"; 
            worksheet.Rows[23].Columns[17] = "Коэффициент консистенции [Па⋅с^n)]";
            worksheet.Rows[23].Columns[18] = _report.Process.Channel.FlowingMaterial.ConsistencyIndex;
            worksheet.Rows[24].Columns[17] = "Коэффициент вязкости [1/°C]"; 
            worksheet.Rows[24].Columns[18] = _report.Process.Channel.FlowingMaterial.ViscosityIndex;
            worksheet.Rows[25].Columns[17] = "Температура приведения [°C]"; 
            worksheet.Rows[25].Columns[18] = _report.Process.Channel.FlowingMaterial.ReferenceTemperature;
            worksheet.Rows[26].Columns[17] = "Индекс течения"; 
            worksheet.Rows[26].Columns[18] = _report.Process.Channel.FlowingMaterial.FlowIndex;
            worksheet.Rows[27].Columns[17] = "Коэффициент теплоотдачи от крышки [Вт/(м^2⋅°C]"; 
            worksheet.Rows[27].Columns[18] = _report.Process.Channel.FlowingMaterial.HeatTransferIndex;
            
            worksheet.Cells[29, 17].Font.Bold = true;
            worksheet.Rows[29].Columns[17] = "Параметры метода решения"; 
            worksheet.Rows[30].Columns[17] = "Шаг расчета по длине канала [м]";
            worksheet.Rows[30].Columns[18] = _report.Process.Channel.CalculationStep;
            
            string str = size.ToString();

            ChartObjects xlCharts = (ChartObjects) worksheet.ChartObjects(Type.Missing);

            ChartObject _temperatureChart = xlCharts.Add(250, 0, 600, 300);
            Chart temperatureChart = _temperatureChart.Chart;
            SeriesCollection temperatureSeriesCollection =
                (SeriesCollection) temperatureChart.SeriesCollection(Type.Missing);
            Series temperature = temperatureSeriesCollection.NewSeries();
            temperature.Name = "Температура, °C";
            temperature.XValues = worksheet.get_Range("A2", "A" + str);
            temperature.Values = worksheet.get_Range("B2", "B" + str);
            temperatureChart.ChartType = XlChartType.xlXYScatterSmooth;
            var temperatureXAxes = temperatureChart.Axes(XlAxisType.xlValue);
            var temperatureYAxes = temperatureChart.Axes(XlAxisType.xlCategory);
            temperatureXAxes.HasTitle = true;
            temperatureXAxes.AxisTitle.Text = "Температура, °C";
            temperatureYAxes.HasTitle = true;
            temperatureYAxes.AxisTitle.Text = "Координата, м";

            ChartObject _viscosityChart = xlCharts.Add(250, 300, 600, 300);
            Chart viscosityChart = _viscosityChart.Chart;
            SeriesCollection viscositySeriesCollection =
                (SeriesCollection) viscosityChart.SeriesCollection(Type.Missing);
            Series viscosity = viscositySeriesCollection.NewSeries();
            viscosity.Name = "Вязкость, Па*с";
            viscosity.XValues = worksheet.get_Range("A2", "A" + str);
            viscosity.Values = worksheet.get_Range("C2", "C" + str);
            viscosityChart.ChartType = XlChartType.xlXYScatterSmooth;
            var viscosityXAxes = viscosityChart.Axes(XlAxisType.xlValue);
            var viscosityYAxes = viscosityChart.Axes(XlAxisType.xlCategory);
            viscosityXAxes.HasTitle = true;
            viscosityXAxes.AxisTitle.Text = "Вязкость, Па*с";
            viscosityYAxes.HasTitle = true;
            viscosityYAxes.AxisTitle.Text = "Координата, м";
            
            var ranges = new List<Range>
            {
                worksheet.get_Range("Q1", "R6"),
                worksheet.get_Range("Q8", "R30"),
                worksheet.get_Range("A1", "C" + str)
            };
            foreach (var range in ranges)
            {
                XlBordersIndex ind;

                ind = XlBordersIndex.xlEdgeLeft;
                range.Borders[ind].Weight = XlBorderWeight.xlMedium;
                range.Borders[ind].LineStyle = XlLineStyle.xlContinuous;
                range.Borders[ind].Color = Color.Black;
                
                ind = XlBordersIndex.xlEdgeRight;
                range.Borders[ind].Weight = XlBorderWeight.xlMedium;
                range.Borders[ind].LineStyle = XlLineStyle.xlContinuous;
                range.Borders[ind].Color = Color.Black;
            
                ind = XlBordersIndex.xlEdgeBottom;
                range.Borders[ind].Weight = XlBorderWeight.xlMedium;
                range.Borders[ind].LineStyle = XlLineStyle.xlContinuous;
                range.Borders[ind].Color = Color.Black;
            
                ind = XlBordersIndex.xlEdgeTop;
                range.Borders[ind].Weight = XlBorderWeight.xlMedium;
                range.Borders[ind].LineStyle = XlLineStyle.xlContinuous;
                range.Borders[ind].Color = Color.Black;   
            }
            
            return workbook;
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