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

        private readonly double[][] _result;

        private Channel Channel { get; }
        private FlowingMaterial FlowingMaterial { get; }

        public Process(Channel channel, FlowingMaterial flowingMaterial)
        {
            Channel = channel;
            FlowingMaterial = flowingMaterial;

            _gamma = CalculateGammaCoefficient();
            _qGamma = CalculateQGamma();
            _qAlpha = CalculateQAlpha();

            var size = CalculateSize();

            _kappa = new double[size + 1];
            _viscosity = new double[size + 1];
            _temperature = new double[size + 1];
            _result = new double[size + 1][];

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

                _result[i] = new double[3];
                _result[i][0] = Math.Round(coordinate, 2);
                _result[i][1] = Math.Round(_temperature[i], 2);
                _result[i][2] = Math.Round(_viscosity[i], 1);
            }
        }

        private double CalculateGammaCoefficient()
        {
            return Channel.Cap.Speed * Channel.Depth;
        }

        private double CalculateQGamma()
        {
            return Channel.Width * Channel.Depth * FlowingMaterial.ConsistencyIndex *
                   Math.Pow(_gamma, FlowingMaterial.FlowIndex - 1);
        }

        private double CalculateQAlpha()
        {
            return Channel.Width * FlowingMaterial.HeatTransferIndex *
                   (1 / FlowingMaterial.ViscosityIndex - Channel.Cap.Temperature +
                    FlowingMaterial.ReferenceTemperature);
        }

        private int CalculateSize()
        {
            return Convert.ToInt32(Math.Ceiling(Channel.Length / Channel.CalculationStep));
        }

        private double CalculateSupportCoefficient()
        {
            return (FlowingMaterial.ViscosityIndex * _qGamma + Channel.Width * FlowingMaterial.HeatTransferIndex) /
                   (FlowingMaterial.ViscosityIndex * _qAlpha);
        }

        private double CalculateKappaCoefficient(double coefficient, double coordinate)
        {
            return coefficient * (1 - Math.Exp(-(coordinate * FlowingMaterial.ViscosityIndex * _qAlpha) /
                                               (Channel.Performance * FlowingMaterial.HeatCapacity))) + Math.Exp(
                FlowingMaterial.ViscosityIndex * (FlowingMaterial.MeltingTemperature -
                                                  FlowingMaterial.ReferenceTemperature -
                                                  coordinate * _qAlpha / (Channel.Performance *
                                                                          FlowingMaterial.HeatCapacity)));
        }

        private double CalculateTemperature(int i)
        {
            return FlowingMaterial.ReferenceTemperature +
                   1 / FlowingMaterial.ViscosityIndex * Math.Log(_kappa[i]);
        }

        private double CalculateViscosity(int i)
        {
            return FlowingMaterial.ConsistencyIndex *
                   Math.Exp(-(FlowingMaterial.ViscosityIndex *
                              (_temperature[i] - FlowingMaterial.ReferenceTemperature))) *
                   Math.Pow(_gamma, FlowingMaterial.FlowIndex - 1);
        }
    }
}