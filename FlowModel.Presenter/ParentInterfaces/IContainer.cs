using System;
using System.Linq.Expressions;

namespace FlowModel.Presenter.ParentInterfaces
{
    public interface IContainer
    {
        void Register<TService, TImplementation>() 
            where TImplementation : TService;
        
        void Register<TService>();
        
        void RegisterInstance<TInstance>(TInstance instance);
        
        TService Resolve<TService>();
        
        bool IsRegistered<TService>();
        
        void Register<TService, TArgument>(Expression<Func<TArgument, TService>> factory);
    }
}