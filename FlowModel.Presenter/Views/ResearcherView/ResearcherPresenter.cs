using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using FlowModel.Model;
using FlowModel.Presenter.ParentInterfaces;
using FlowModel.Presenter.Views.ReportView;
using Process = FlowModel.Model.Process;

namespace FlowModel.Presenter.Views.ResearcherView
{
    public class ResearcherPresenter : BasePresenter<IResearcherView>
    {
        private long _memory;
        
        private Process _process;

        private ViewReport _report;

        private readonly MockProcessUnitOfWork _unitOfWork;

        private Stopwatch _time;

        public ResearcherPresenter(IApplicationController controller, IResearcherView view) : base(controller, view)
        {
            _process = new Process();

            _unitOfWork = new MockProcessUnitOfWork();
            
            foreach (var material in _unitOfWork.Materials.GetList())
            {
                View.MaterialItem = material.Name;
            }

            View.SelectMaterial += SelectMaterial;
            
            View.Calculate += Calculate;

            View.Open += Open;
            View.Save += Save;
            View.Export += Export;
            View.Exit += Exit;

            View.Settings += Settings;
            View.Help += Help;
            View.About += About;
        }

        private void SelectMaterial()
        {
            var material = _unitOfWork.Materials.GetList().First(x => x.Name == View.MaterialSelectedItem);

            View.Density.Value = _unitOfWork.MaterialParameters.GetList().First(x => x.MaterialId == material.Id && x.Parameter.Name == "Density").ParameterValue.ToString();
            View.HeatCapacity.Value = _unitOfWork.MaterialParameters.GetList().First(x => x.MaterialId == material.Id && x.Parameter.Name == "Heat capacity").ParameterValue.ToString();
            View.MeltingTemperature.Value = _unitOfWork.MaterialParameters.GetList().First(x => x.MaterialId == material.Id && x.Parameter.Name == "Melting temperature").ParameterValue.ToString();

            View.ConsistencyIndex.Value = _unitOfWork.MaterialParameters.GetList().First(x => x.MaterialId == material.Id && x.Parameter.Name == "Consistency index").ParameterValue.ToString();
            View.ViscosityIndex.Value = _unitOfWork.MaterialParameters.GetList().First(x => x.MaterialId == material.Id && x.Parameter.Name == "Viscosity index").ParameterValue.ToString();
            View.ReferenceTemperature.Value = _unitOfWork.MaterialParameters.GetList().First(x => x.MaterialId == material.Id && x.Parameter.Name == "Reference temperature").ParameterValue.ToString();
            View.FlowIndex.Value = _unitOfWork.MaterialParameters.GetList().First(x => x.MaterialId == material.Id && x.Parameter.Name == "Flow index").ParameterValue.ToString();
            View.HeatTransferIndex.Value = _unitOfWork.MaterialParameters.GetList().First(x => x.MaterialId == material.Id && x.Parameter.Name == "Heat transfer index").ParameterValue.ToString();
        }

        private void Calculation()
        {
            _time = new Stopwatch();
            _time.Start();
            var startMemory = GC.GetAllocatedBytesForCurrentThread();
            
            var cap = new Cap(Convert.ToDouble(View.LidTemperature.Value), Convert.ToDouble(View.LidSpeed.Value));

            var flowingMaterial = new FlowingMaterial(Convert.ToDouble(View.MeltingTemperature.Value),
                Convert.ToDouble(View.HeatCapacity.Value), Convert.ToDouble(View.ReferenceTemperature.Value),
                Convert.ToDouble(View.ViscosityIndex.Value), Convert.ToDouble(View.HeatTransferIndex.Value),
                Convert.ToDouble(View.ConsistencyIndex.Value), Convert.ToDouble(View.FlowIndex.Value),
                Convert.ToDouble(View.Density.Value));

            var channel = new Channel(Convert.ToDouble(View.Width.Value), Convert.ToDouble(View.Depth.Value),
                Convert.ToDouble(View.Length.Value), Convert.ToDouble(View.Step.Value), cap, flowingMaterial);

            _process = new Process(channel);
         
            var endMemory = GC.GetAllocatedBytesForCurrentThread();
            _memory = endMemory - startMemory;
            _time.Stop();

            _report = new ViewReport(_process, _memory, _time.ElapsedMilliseconds);
        }
        
        private void Calculate()
        {
            ParametersCheck();
           
            Task calculation = Task.Run(Calculation);
            View.IsProcessing = true;
            calculation.Wait();
            View.IsProcessing = false;

            Controller.Run<ReportPresenter, ViewReport>(_report);
           
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

            if (!(Convert.ToDouble(View.Length.Value) / Convert.ToDouble(View.Step.Value) > 5000)) return;
            View.Step.Value = (Convert.ToDouble(View.Length.Value) / 5000).ToString();
            throw new ArgumentException("Количество шагов не может привышать 5000. Значение шага увеличено.", View.Step.ParameterName);
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
                    throw new ArgumentException("Недопустимый формат параметра: " + parameter.ParameterName);
                }
                if (Convert.ToDouble(parameter.Value) < 0.001)
                {
                    throw new ArgumentException("Параметр не может быть меньше 0,001:" + parameter.ParameterName);
                }
            }
            else
            {
                parameter.IsIncorrect = true;
                throw new ArgumentNullException(parameter.ParameterName);
            }
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