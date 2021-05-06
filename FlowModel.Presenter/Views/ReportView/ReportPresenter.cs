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
    }
}
