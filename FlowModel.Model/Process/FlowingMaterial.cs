// ReSharper disable ClassNeverInstantiated.Global
namespace FlowModel.Model
{
    public class FlowingMaterial
    {
        public double ResultViscosity { get; set; }
        public double ResultTemperature { get; set; }
        
        public double Density { get; }
        public double FlowIndex { get; }
        public double HeatCapacity { get; }
        public double ViscosityIndex { get; }
        public double ConsistencyIndex { get; }
        public double HeatTransferIndex { get; }
        public double MeltingTemperature { get; }
        public double ReferenceTemperature { get; }

        public FlowingMaterial(double meltingTemperature, double heatCapacity, double referenceTemperature,
            double viscosityIndex, double heatTransferIndex, double consistencyIndex, double flowIndex, double density)
        {
            Density = density;
            FlowIndex = flowIndex;
            HeatCapacity = heatCapacity;
            ViscosityIndex = viscosityIndex;
            ConsistencyIndex = consistencyIndex;
            HeatTransferIndex = heatTransferIndex;
            MeltingTemperature = meltingTemperature;
            ReferenceTemperature = referenceTemperature;
        }
    }
}