using System;

namespace FlowModel.Presenter.Views.ResearcherView
{
    public interface IResearcherView : IFileMenuView, IHelpMenuView,
        IChannelParameters, IMaterialParameters, ICapParameters, IMethodParameters
    {
        IParameterInput Step { get; set; }
        
        bool IsProcessing { set; }
        
        event Action Calculate;

        event Action ShowValueTable;
        event Action ShowTemperatureChart;
        event Action ShowViscosityChart;
    }
}