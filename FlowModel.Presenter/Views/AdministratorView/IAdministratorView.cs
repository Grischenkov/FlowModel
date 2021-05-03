using System;
using FlowModel.Presenter.Views.AdministratorView.EntityInterfaces;

namespace FlowModel.Presenter.Views.AdministratorView
{
    public interface IAdministratorView : IFileMenuView, IHelpMenuView,
        IMaterial, IMaterialParameters, IParameters, ITypes, IUnits, IUsers, IReports
    {
    }
}