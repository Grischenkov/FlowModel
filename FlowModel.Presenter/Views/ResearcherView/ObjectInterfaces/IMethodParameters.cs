namespace FlowModel.Presenter.Views.ResearcherView
{
    public interface IMethodParameters
    {
        IParameterInput FlowIndex { get; set; }
        IParameterInput ViscosityIndex { get; set; }
        IParameterInput ConsistencyIndex { get; set; }
        IParameterInput HeatTransferIndex { get; set; }
        IParameterInput ReferenceTemperature { get; set; }
    }
}