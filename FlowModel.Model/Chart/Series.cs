using System;
using System.Linq.Expressions;

namespace FlowModel.Model
{
    public class Series
    {
        private int _size; 

        private double[][] Table { get; set; }
        
        public int Size
        {
            get => _size;
            private set
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
        
        private double[] XAxis { get; set; }
        private double[] YAxis { get; set; }

        public Series(double[] xAxis, double[] yAxis)
        {
            if (xAxis.Length == yAxis.Length)
            {
                XAxis = xAxis;
                YAxis = yAxis;

                Size = xAxis.Length;

                for (var i = 0; i < Size; i++)
                {
                    Table[i][0] = xAxis[i];
                    Table[i][1] = yAxis[i];
                }
            }
            else
            {
                throw new ArgumentException("Incorrect size!");
            }
        }
    }
}