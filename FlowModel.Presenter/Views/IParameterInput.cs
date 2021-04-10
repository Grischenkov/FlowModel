namespace FlowModel.Presenter
{
    public interface IParameterInput
    {
        string MeasurementUnit { get; }
        string Name { get; }
        string Value { get; set; }

        bool IsEnabled { get; set; }
        
        bool IsIncorrect { set; }
    }
}