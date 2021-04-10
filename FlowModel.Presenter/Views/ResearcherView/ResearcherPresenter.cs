using System;
using System.Diagnostics;
using FlowModel.Model;
using FlowModel.Presenter.ParentInterfaces;
using Process = FlowModel.Model.Process;

namespace FlowModel.Presenter.Views.ResearcherView
{
    public class ResearcherPresenter : BasePresenter<IResearcherView>
    {
        private long _memory;
        
        private Process _process;

        private Graph _temperatureChart;
        private Graph _viscosityChart;

        private readonly Stopwatch _time;

        public ResearcherPresenter(IApplicationController controller, IResearcherView view) : base(controller, view)
        {
            _process = new Process();

            _temperatureChart = new Graph();
            _viscosityChart = new Graph();
            
            _time = new Stopwatch();
            
            View.Calculate += Calculate;

            View.ShowValueTable += ShowValueTable;
            View.ShowTemperatureChart += ShowTemperatureChart;
            View.ShowViscosityChart += ShowViscosityChart;

            View.Open += Open;
            View.Save += Save;
            View.Export += Export;
            View.Exit += Exit;

            View.Settings += Settings;
            View.Help += Help;
            View.About += About;
        }

        private void Calculate()
        {
            ParametersCheck();

            _time.Start();
            var startMemory = GC.GetAllocatedBytesForCurrentThread();
            
            var cap = new Cap(Convert.ToDouble(View.LidTemperature), Convert.ToDouble(View.LidSpeed));

            var flowingMaterial = new FlowingMaterial(Convert.ToDouble(View.MeltingTemperature),
                Convert.ToDouble(View.HeatCapacity), Convert.ToDouble(View.ReferenceTemperature),
                Convert.ToDouble(View.ViscosityIndex), Convert.ToDouble(View.HeatTransferIndex),
                Convert.ToDouble(View.ConsistencyIndex), Convert.ToDouble(View.FlowIndex),
                Convert.ToDouble(View.Density));

            var channel = new Channel(Convert.ToDouble(View.Width), Convert.ToDouble(View.Depth),
                Convert.ToDouble(View.Length), Convert.ToDouble(View.Step), cap, flowingMaterial);

            _process = new Process(channel);

            _temperatureChart = new Graph
            {
                Name = "Температура",
                XAxisName = "Координата, м",
                YAxisName = "Температура, °C",
                Series = new Series
                {
                    XAxis = _process.Parameters[0],
                    YAxis = _process.Parameters[1]   
                }
            };
            _viscosityChart = new Graph
            {
                Name = "Вязкость",
                XAxisName = "Координата, м",
                YAxisName = "Вязкость, Па*с",
                Series = new Series
                {
                    XAxis = _process.Parameters[0],
                    YAxis = _process.Parameters[2]
                }
            };
            
            var endMemory = GC.GetAllocatedBytesForCurrentThread();
            _memory = endMemory - startMemory;
            _time.Stop();

            ViewResults();
        }

        private void ViewResults()
        {
            View.Time = (_time.ElapsedMilliseconds * 1000).ToString();
            View.Memory = _memory.ToString();

            View.Performance = Process.Channel.Performance.ToString();
            View.Viscosity = Process.Viscosity.ToString();
            View.Temperature = Process.Temperature.ToString();
        }
        
        private void ParametersCheck()
        {
            ValueCheck(View.Width);
            ValueCheck(View.Depth);
            ValueCheck(View.Length);
            
            ValueCheck(View.Density);
            ValueCheck(View.HeatCapacity);
            ValueCheck(View.MeltingTemperature);
            
            ValueCheck(View.LidTemperature);
            ValueCheck(View.LidSpeed);
            
            ValueCheck(View.Step);
            
            ValueCheck(View.FlowIndex);
            ValueCheck(View.ViscosityIndex);
            ValueCheck(View.ConsistencyIndex);
            ValueCheck(View.HeatTransferIndex);
            ValueCheck(View.ReferenceTemperature);
        }
        
        private void ValueCheck(IParameterInput parameter)
        {
            if (!string.IsNullOrEmpty(parameter.Value))
            {
                try
                {
                    Convert.ToDouble(parameter.Value);
                }
                catch (Exception e)
                {
                    parameter.IsIncorrect = true;
                    throw new ArgumentException("Недопустимый формат параметра: " + parameter.Name);
                }
            }
            else
            {
                parameter.IsIncorrect = true;
                throw new ArgumentNullException(parameter.Name);
            }
        }
        
        private void ShowValueTable()
        {
            //Controller.Run<ValueTablePresenter, Parameters>(_process.Parameters);
        }

        private void ShowTemperatureChart()
        {
            //Controller.Run<TemperatureChartPresenter, Chart>(_temperatureChart);
        }

        private void ShowViscosityChart()
        {
            //Controller.Run<ViscosityChartPresenter, Chart>(_viscosityChart);
        }

        private void Open()
        {
            //TODO Implement loading functionality
        }

        private void Save()
        {
            //TODO Implement saving functionality            
        }

        private void Export()
        {
            //TODO Implement export functionality
        }

        private void Settings()
        {
            //Controller.Run<SettingsPresenter>();
        }

        private void Help()
        {
            //Controller.Run<HelpPresenter>();
        }

        private void About()
        {
            //Controller.Run<AboutPresenter>();
        }
    }
}