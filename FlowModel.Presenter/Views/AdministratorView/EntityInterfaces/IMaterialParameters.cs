using System;

namespace FlowModel.Presenter.Views.AdministratorView.EntityInterfaces
{
    public interface IMaterialParameters
    {
        void FillMaterialParametersRecords(string[][] records);
        string MaterialParametersId { get; set; }
        void MaterialItemsClear();
        string MaterialItem { get; set; }
        string MaterialParametersMaterial { get; set; }
        void ParameterItemsClear();
        string ParameterItem { get; set; }
        string MaterialParametersParameter { get; set; }
        string ParameterValue { get; set; }
        event Action AddMaterialParameter;
        event Action DeleteMaterialParameter;
    }
}