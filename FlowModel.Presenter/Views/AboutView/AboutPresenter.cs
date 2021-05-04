using FlowModel.Presenter.ParentInterfaces;

namespace FlowModel.Presenter.Views.AboutView
{
    public class AboutPresenter : BasePresenter<IAboutView>
    {
        public AboutPresenter(IApplicationController controller, IAboutView view) : base(controller, view)
        {
        }
    }
}