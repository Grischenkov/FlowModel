using FlowModel.Presenter.ParentInterfaces;

namespace FlowModel.Presenter.Views.AddDataTable
{
    public interface IDataTableView : IView
    {
        void DrawTable(double[,] table);
    }
}