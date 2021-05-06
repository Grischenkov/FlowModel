using System;
using FlowModel.Presenter.ParentInterfaces;

namespace FlowModel.Presenter.Views
{
    public interface IFileMenuView : IView
    {
        event Action Open;
        event Action Save;
        event Action Export;
        event Action Logout;
        event Action Exit;
    }
}