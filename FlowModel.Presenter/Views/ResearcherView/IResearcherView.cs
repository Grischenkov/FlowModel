using System;

namespace FlowModel.Presenter.Views.ResearcherView
{
    public interface IResearcherView : IFileMenuView, IHelpMenuView,
        IChannelParameters, IMaterialParameters, ICapParameters, IMethodParameters
    {
        IParameterInput Step { get; }

        string Viscosity { set; }
        string Temperature { set; }
        string Performance { set; }
        
        string Time { set; }
        string Memory { set; }
        
        event Action Calculate;

        event Action ShowValueTable;
        event Action ShowTemperatureChart;
        event Action ShowViscosityChart;
    }
}