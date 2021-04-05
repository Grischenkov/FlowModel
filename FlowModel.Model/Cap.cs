// ReSharper disable ClassNeverInstantiated.Global
namespace FlowModel.Model
{
    public sealed class Cap
    {
        public double Speed { get; }
        public double Temperature { get; }

        public Cap(double temperature, double speed)
        {
            Temperature = temperature;
            Speed = speed;
        }
    }
}