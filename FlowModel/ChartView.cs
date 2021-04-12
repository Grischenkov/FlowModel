using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FlowModel
{
    public partial class ChartView : Form, IChartView
    {
        public string ChartName
        {
            get => ChartName;
            set
            {
                ChartName = value;
                InitializeChart();
            }
        }

        public string XAxisName
        {
            get => XAxisName;
            set
            {
                XAxisName = value;
                InitializeChart();
            }
        }

        public string YAxisName
        {
            get => YAxisName;
            set
            {
                YAxisName = value;
                InitializeChart();
            }
        }

        private Series _series;

        public ChartView()
        {
            InitializeComponent();
            InitializeChart();
        }
        
        public new void Show()
        {
            this.ShowDialog();
        }
        
        public void DrawChart(double[][] table)
        {
            chart.Series[0].Points.Clear();
            foreach (var point in table)
            {
                chart.Series[0].Points.AddXY(point[0], point[1]);
            }
        }

        private void InitializeChart()
        {
            Name = ChartName;
            Text = Name;
            
            _series = new Series(Name);

            var chartArea = new ChartArea(Name)
            {
                AxisX =
                {
                    Name = XAxisName
                }, 
                AxisY =
                {
                    Name = YAxisName
                }
            };

            chart.ChartAreas.Clear();
            chart.ChartAreas.Add(chartArea);
        }
    }
}