namespace FlowModel.Presenter.ParentInterfaces
{
    public interface IPresenter
    {
        void Run();

        void Exit();
    }

    public interface IPresenter<in TArg>
    {
        void Run(TArg argument1);
    }
}