using System;
using FlowModel.Presenter.ParentInterfaces;

namespace FlowModel.Presenter.Views
{
    public interface IHelpMenuView : IView
    {
        event Action Settings;
        event Action Help;
        event Action About;   
    }
}