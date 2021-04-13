using System;

// ReSharper disable ClassNeverInstantiated.Global
namespace FlowModel.Model
{
    public sealed class Channel
    {
        private readonly double _qChannel;

        public Cap Cap { get; }
        public FlowingMaterial FlowingMaterial { get; }

        public double Width { get; }
        public double Depth { get; }
        public double Length { get; }

        public double CalculationStep { get; }

        public double Performance => Math.Round(FlowingMaterial.Density * _qChannel * 3600, 2);

        public Channel(double width, double depth, double length, double calculationStep, Cap cap, FlowingMaterial flowingMaterial)
        {
            Width = width;
            Depth = depth;
            Length = length;

            CalculationStep = calculationStep;
            
            Cap = cap;
            FlowingMaterial = flowingMaterial;

            var f = 0.125 * Math.Pow((Depth / Width), 2) - 0.625 * (Depth / Width) + 1;
            _qChannel = (Width * Cap.Speed * Depth * f) / 2;
        }
    }
}