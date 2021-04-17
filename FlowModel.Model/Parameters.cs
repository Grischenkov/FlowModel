namespace FlowModel.Model
{
    public class Parameters
    {
        private int _size; 

        public double[][] Table { get; set; }
        
        public int Size
        {
            get => _size;
            set
            {
                _size = value;
                Table = new double[_size][];
                for (var i = 0; i < _size; i++)
                {
                    Table[i] = new double[3];
                }
            }
        }

        public double this[int i, int j] { get => Table[i][j]; set => Table[i][j] = value; }
        
        public double[] this[int i]
        {
            get
            {
                var arr = new double[Size];
                for (var j = 0; j < _size; j++)
                {
                    arr[j] = Table[j][i];
                }
                return arr;
            }
        }
    }
}