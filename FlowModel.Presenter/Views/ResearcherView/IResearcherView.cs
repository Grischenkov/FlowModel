using System;

namespace FlowModel.Presenter.Views.ResearcherView
{
    public interface IResearcherView : IFileMenuView, IHelpMenuView
    {
        string MaterialItem { get; set; }
        string MaterialSelectedItem { get; set; }
        
        string Width { get; }
        string Depth { get; }
        string Length { get; }
        
        string Density { get; set; }
        string HeatCapacity { get; set; }
        string MeltingTemperature { get; set; }
        
        string LidSpeed { get; }
        string LidTemperature { get; }
        
        string Step { get; }
        
        string FlowIndex { get; set; }
        string ViscosityIndex { get; set; }
        string ConsistencyIndex { get; set; }
        string HeatTransferIndex { get; set; }
        string ReferenceTemperature { get; set; }
        
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