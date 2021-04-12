using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FlowModel
{
    public partial class ChartView : Form
    {
        private Series _series;

        public ChartView(string name, string xAxisName, string yAxisName)
        {
            InitializeComponent();
            Name = name;
            Text = Name;
            
            _series = new Series(Name);

            var chartArea = new ChartArea(Name)
            {
                AxisX =
                {
                    Name = xAxisName
                }, 
                AxisY =
                {
                    Name = yAxisName
                }
            };

            chart.ChartAreas.Clear();
            chart.ChartAreas.Add(chartArea);
        }
        
        public new void Show()
        {
            this.ShowDialog();
        }
        
        public void DrawChart(double[][] table)
        {
            chart.Series[0].Points.Clear();
            foreach (var t in table)
            {
                chart.Series[0].Points.AddXY(t[0], t[1]);
            }
        }
    }
}