namespace FlowModel.Presenter.ParentInterfaces
{
    public interface IView
    {
        void Show();
        void Close();
        
        void ShowError(string errorMessage);
        void ShowWarning(string warningMessage);
        void ShowSuccess(string successMessage);
    }
}