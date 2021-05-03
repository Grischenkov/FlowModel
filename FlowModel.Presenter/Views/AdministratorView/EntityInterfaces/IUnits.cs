using System;

namespace FlowModel.Presenter.Views.AdministratorView.EntityInterfaces
{
    public interface IUnits
    {
        void FillUnitsRecords(string[][] records);
        string UnitId { get; set; }
        string UnitName { get; set; }
        event Action AddUnit;
        event Action DeleteUnit;
    }
}