namespace FlowModel.Model
{
    public class Graph
    {
        public string Name { get; }
        
        public Series Series { get; }
        
        public string XAxisName { get; }
        
        public string YAxisName { get; }
        
        public Graph(string name, string xAxisName, string yAxisName, Series series)
        {
            Name = name;
            Series = series;
            XAxisName = xAxisName;
            YAxisName = yAxisName;
        }
    }
}