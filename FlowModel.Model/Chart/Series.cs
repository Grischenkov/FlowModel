namespace FlowModel.Model
{
    public class Series
    {
        private int _size; 

        private double[][] Table { get; set; }
        
        public int Size
        {
            get => _size;
            set
            {
                _size = value;
                Table = new double[_size][];
                for (var i = 0; i < _size; i++)
                {
                    Table[i] = new double[2];
                }
            }
        }

        public double this[int i, int j] { get => Table[i][j]; set => Table[i][j] = value; }
    }
}