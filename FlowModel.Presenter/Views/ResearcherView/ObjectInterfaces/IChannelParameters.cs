namespace FlowModel.Presenter.Views.ResearcherView
{
    public interface IChannelParameters
    {
        IParameterInput Width { get; }
        IParameterInput Depth { get; }
        IParameterInput Length { get; }
    }
}