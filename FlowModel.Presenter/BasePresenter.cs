using FlowModel.Presenter.ParentInterfaces;

namespace FlowModel.Presenter
{
    public abstract class BasePresenter<TView> : IPresenter
        where TView : IView
    {
        protected TView View { get; private set; }

        protected IApplicationController Controller { get; private set; }

        protected BasePresenter(IApplicationController controller, TView view)
        {
            Controller = controller;
            View = view;
        }
        
        public void Run()
        {
            View.Show();
        }
        
        public void Exit()
        {
            View.Close();
        }
    }

    public abstract class BasePresenter<TView, TArg> : IPresenter<TArg>
        where TView : IView
    {
        protected TView View { get; private set; }

        protected IApplicationController Controller { get; private set; }

        protected BasePresenter(IApplicationController controller, TView view)
        {
            Controller = controller;
            View = view;
        }

        public abstract void Run(TArg argument);
    }
}
