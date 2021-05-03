using System;

namespace FlowModel.Presenter.Views.AdministratorView.EntityInterfaces
{
    public interface IParameters
    {
        void FillParametersRecords(string[][] records);
        string ParameterId { get; set; }
        string ParameterName { get; set; }
        void TypeItemsClear();
        string TypeItem { get; set; }
        string ParameterType { get; set; }
        void UnitItemsClear();
        string UnitItem { get; set; }
        string ParameterUnit { get; set; }
        event Action AddParameter;
        event Action DeleteParameter;
    }
}