using System;

namespace FlowModel.Presenter.Views.AdministratorView.EntityInterfaces
{
    public interface IMaterial
    {
        void FillMaterialsRecords(string[][] records);
        string MaterialId { get; set; }
        string MaterialName { get; set; }
        event Action AddMaterial;
        event Action DeleteMaterial;
    }
}