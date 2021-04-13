using FlowModel.Model;
using FlowModel.Presenter.ParentInterfaces;

namespace FlowModel.Presenter.Views.AddDataTable
{
    public class DataTablePresenter : BasePresenter<IDataTableView, Parameters>
    {
        public DataTablePresenter(IApplicationController controller, IDataTableView view) : base(controller, view)
        {
        }

        public override void Run(Parameters parameters)
        {
            var arr = new double[parameters.Size][];
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = new double[3];
                arr[i][0] = parameters[i,0];
                arr[i][1] = parameters[i,1];
                arr[i][2] = parameters[i,2];
            }
            View.DrawTable(arr);
            View.Show();
        }
    }
}