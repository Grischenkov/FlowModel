using System;
using FlowModel.Presenter.ParentInterfaces;

namespace FlowModel.Presenter.Views
{
    public interface ILoginView : IView
    {
        string Login { get; }
        
        string Password { get; }

        event Action Log;
    }
}