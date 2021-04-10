namespace FlowModel.Presenter.Views.ResearcherView
{
    public interface IMaterialParameters
    {
        string MaterialItem { get; set; }
        string MaterialSelectedItem { get; set; }
        
        IParameterInput Density { get; set; }
        IParameterInput HeatCapacity { get; set; }
        IParameterInput MeltingTemperature { get; set; }
    }
}