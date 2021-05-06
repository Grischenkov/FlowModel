using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FlowModel.Presenter.Views.ReportView;

namespace FlowModel
{
    public sealed partial class ReportView : Form, IReportView
    {
        public string Time {  set=> time_Label.Text = value; }
        public string Memory {  set=> memory_Label.Text = value; }
        public string Performance {  set=> performance_Label.Text = value; }
        public string ResultTemperature {  set=> temperature_Label.Text = value; }
        public string ResultViscosity {  set=> viscosity_Label.Text = value; }
        
        private Series _temperatureSeries;
        private Series _viscositySeries;

        public event Action Export;

        public ReportView()
        {
            InitializeComponent();
            export_Button.Click += (sender, args) => Action(Export);
            DoubleBuffered = true;
            InitializeChart();
        }

        private void Action(Action action)
        {
            try
            {
                action?.Invoke();
            }
            catch (Exception e)
            {
                ShowError(e.Message);
            }
        }

        public void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowWarning(string warningMessage)
        {
            MessageBox.Show(warningMessage, @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void ShowSuccess(string successMessage)
        {
            MessageBox.Show(successMessage, @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void InitializeChart()
        {
            _temperatureSeries = new Series("Температура")
            {
                ChartType = SeriesChartType.Line,
                MarkerStyle = MarkerStyle.Circle
            };
            _viscositySeries = new Series("Вязкость")
            {
                ChartType = SeriesChartType.Line,
                MarkerStyle = MarkerStyle.Circle
            };
            
            temperature_Chart.Series.Clear();
            temperature_Chart.Series.Add(_temperatureSeries);
            temperature_Chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            temperature_Chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            temperature_Chart.ChartAreas[0].AxisX.Title = "Координата, м";
            temperature_Chart.ChartAreas[0].AxisY.Title = "Температура, °C";
            temperature_Chart.Series[0].ToolTip = "Координата, м: #VALX " + "\n" + "Температура, °C: #VALY";
        
            viscosity_Chart.Series.Clear();
            viscosity_Chart.Series.Add(_viscositySeries);
            viscosity_Chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            viscosity_Chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            viscosity_Chart.ChartAreas[0].AxisX.Title = "Координата, м";
            viscosity_Chart.ChartAreas[0].AxisY.Title = "Вязкость, Па*с";
            viscosity_Chart.Series[0].ToolTip = "Координата, м: #VALX " + "\n" + "Вязкость, Па*с: #VALY";
        }

        public void DrawResults(double[][] results)
        {
            for (int i = 0, j = 0; i < results.Length; i++)
            {
                dataGridView.RowCount = j + 1;
                
                temperature_Chart.Series[0].Points.AddXY(results[i][0], results[i][1]);
                viscosity_Chart.Series[0].Points.AddXY(results[i][0], results[i][2]);
                
                dataGridView.Rows[j].Cells[0].Value = results[i][0].ToString();
                dataGridView.Rows[j].Cells[1].Value = results[i][1].ToString();
                dataGridView.Rows[j].Cells[2].Value = results[i][2].ToString();
                
                j++;
            }
        }
    }
}