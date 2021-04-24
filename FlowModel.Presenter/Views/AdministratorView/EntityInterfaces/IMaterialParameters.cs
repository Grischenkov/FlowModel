using System;

namespace FlowModel.Presenter.Views.AdministratorView.EntityInterfaces
{
    public interface IMaterialParameters
    {
        void FillMaterialParametersRecords(string[][] records);
        string MaterialParametersId { get; set; }
        string MaterialItem { get; set; }
        string MaterialParametersMaterial { get; set; }
        string ParameterItem { get; set; }
        string MaterialParametersParameter { get; set; }
        string MaterialParametersParameterValue { get; set; }
        event Action AddMaterialParameter;
        event Action DeleteMaterialParameter;
    }
}