using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FlowModel.Model
{
    public class ViewReport
    {
        public double Memory { get; private set; }
        
        public double Time { get; private set; }

        public Process Process { get; private set; }
        
        public ViewReport(Process process, double memory, double time)
        {
            Process = process;
            Memory = memory / 1000;
            Time = time;
        }
    }
}