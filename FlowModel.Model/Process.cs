using System;

// ReSharper disable PrivateFieldCanBeConvertedToLocalVariable
namespace FlowModel.Model
{
    public sealed class Process
    {
        private readonly double _gamma;
        private readonly double _qGamma;
        private readonly double _qAlpha;
        
        private readonly double[] _kappa;
        private readonly double[] _viscosity;
        private readonly double[] _temperature;
        
        private Channel Channel { get; }
        
        public Parameters Parameters { get; }

        public Process()
        {
        }

        public Process(Channel channel)
        {
            Parameters = new Parameters();
            
            Channel = channel;
            _gamma = CalculateGammaCoefficient();
            _qGamma = CalculateQGamma();
            _qAlpha = CalculateQAlpha();
            var size = CalculateSize();
            _kappa = new double[size + 1];
            _viscosity = new double[size + 1];
            _temperature = new double[size + 1];
            Parameters.Size = size;
            CalculateProcessParameters();
        }

        private void CalculateProcessParameters()
        {
            var coefficient = CalculateSupportCoefficient();
            for (var i = 0; i < _kappa.Length; i++)
            {
                var coordinate = i * Channel.CalculationStep;
                _kappa[i] = CalculateKappaCoefficient(coefficient, coordinate);
                _temperature[i] = CalculateTemperature(i);
                _viscosity[i] = CalculateViscosity(i);
                Parameters[i,0] = Math.Round(coordinate, 2);
                Parameters[i,1] = Math.Round(_temperature[i], 2);
                Parameters[i,2] = Math.Round(_viscosity[i], 1);
            }
        }

        private double CalculateGammaCoefficient()
        {
            return Channel.Cap.Speed * Channel.Depth;
        }

        private double CalculateQGamma()
        {
            return Channel.Width * Channel.Depth * Channel.FlowingMaterial.ConsistencyIndex *
                   Math.Pow(_gamma, Channel.FlowingMaterial.FlowIndex - 1);
        }

        private double CalculateQAlpha()
        {
            return Channel.Width * Channel.FlowingMaterial.HeatTransferIndex *
                   (1 / Channel.FlowingMaterial.ViscosityIndex - Channel.Cap.Temperature +
                    Channel.FlowingMaterial.ReferenceTemperature);
        }

        private int CalculateSize()
        {
            return Convert.ToInt32(Math.Ceiling(Channel.Length / Channel.CalculationStep));
        }

        private double CalculateSupportCoefficient()
        {
            return (Channel.FlowingMaterial.ViscosityIndex * _qGamma +
                    Channel.Width * Channel.FlowingMaterial.HeatTransferIndex) /
                   (Channel.FlowingMaterial.ViscosityIndex * _qAlpha);
        }

        private double CalculateKappaCoefficient(double coefficient, double coordinate)
        {
            return coefficient * (1 - Math.Exp(-(coordinate * Channel.FlowingMaterial.ViscosityIndex * _qAlpha) /
                                               (Channel.Performance * Channel.FlowingMaterial.HeatCapacity))) +
                   Math.Exp(Channel.FlowingMaterial.ViscosityIndex * (Channel.FlowingMaterial.MeltingTemperature -
                                                                      Channel.FlowingMaterial.ReferenceTemperature -
                                                                      coordinate * _qAlpha / (Channel.Performance *
                                                                          Channel.FlowingMaterial.HeatCapacity)));
        }

        private double CalculateTemperature(int i)
        {
            return Channel.FlowingMaterial.ReferenceTemperature +
                   1 / Channel.FlowingMaterial.ViscosityIndex * Math.Log(_kappa[i]);
        }

        private double CalculateViscosity(int i)
        {
            return Channel.FlowingMaterial.ConsistencyIndex *
                   Math.Exp(-(Channel.FlowingMaterial.ViscosityIndex *
                              (_temperature[i] - Channel.FlowingMaterial.ReferenceTemperature))) *
                   Math.Pow(_gamma, Channel.FlowingMaterial.FlowIndex - 1);
        }
    }
}