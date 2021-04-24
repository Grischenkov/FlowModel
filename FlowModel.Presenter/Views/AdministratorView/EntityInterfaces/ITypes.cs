using System;

namespace FlowModel.Presenter.Views.AdministratorView.EntityInterfaces
{
    public interface ITypes
    {
        void FillTypesRecords(string[][] records);
        string TypeId { get; set; }
        string TypeName { get; set; }
        event Action AddType;
        event Action DeleteType;
    }
}