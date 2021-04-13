using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using FlowModel.Presenter.Views.ChartView;

namespace FlowModel
{
    public partial class ChartView : Form, IChartView
    {
        private string xAxisName;
        private string yAxisName;
        
        public string ChartName
        {
            set => InitializeChart(value);
        }

        public string XAxisName
        {
            get => xAxisName;
            set
            {
                xAxisName = value;
                InitializeToolTip();
            }
        }

        public string YAxisName
        {
            get => yAxisName;
            set
            {
                yAxisName = value;
                InitializeToolTip();
            }
        }

        private Series _series;

        public ChartView()
        {
            InitializeComponent();
        }
        
        public new void Show()
        {
            ShowDialog();
        }

        public void ShowError(string errorMessage)
        {
            throw new System.NotImplementedException();
        }

        public void ShowWarning(string warningMessage)
        {
            throw new System.NotImplementedException();
        }

        public void ShowSuccess(string successMessage)
        {
            throw new System.NotImplementedException();
        }

        public void DrawChart(double[][] table)
        {
            chart.Series[0].Points.Clear();
            foreach (var point in table)
            {
                chart.Series[0].Points.AddXY(point[0], point[1]);
            }
        }

        private void InitializeChart(string name)
        {
            Name = name;
            Text = Name;

            _series = new Series(Name)
            {
                ChartType = SeriesChartType.Line, 
                MarkerStyle = MarkerStyle.Circle
            };
            chart.Series.Clear();
            chart.Series.Add(_series);
            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
        }

        private void InitializeToolTip()
        {
            chart.ChartAreas[0].AxisX.Title = XAxisName;
            chart.ChartAreas[0].AxisY.Title = YAxisName;
            chart.Series[0].ToolTip = $"{XAxisName}: #VALX " + "\n" + $"{YAxisName}: #VALY";
        }
    }
}