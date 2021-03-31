using FlowModel.Presenter.ParentInterfaces;

namespace FlowModel.Presenter.Views.ResearcherView
{
    public class ResearcherPresenter : BasePresenter<IResearcherView>
    {
        public ResearcherPresenter(IApplicationController controller, IResearcherView view) : base(controller, view)
        {
            View.Calculate += Calculate;

            View.ShowValueTable += ShowValueTable;
            View.ShowTemperatureChart += ShowTemperatureChart;
            View.ShowViscosityChart += ShowViscosityChart;
            
            View.Open += Open;
            View.Save += Save;
            View.Export += Export;
            View.Exit += Exit;

            View.Settings += Settings;
            View.Help += Help;
            View.About += About;
        }

        private void Calculate()
        {
            //TODO Implement calculation algorithm
        }

        private void ShowValueTable()
        {
            //Controller.Run<ValueTablePresenter>();
        }
        private void ShowTemperatureChart()
        {
            //Controller.Run<TemperatureChartPresenter>();
        }
        private void ShowViscosityChart()
        {
            //Controller.Run<ViscosityChartPresenter>();
        }
        
        private void Open()
        {
            //TODO Implement loading functionality
        }
        private void Save()
        {
            //TODO Implement saving functionality            
        }
        private void Export()
        {
            //TODO Implement export functionality
        }

        private void Settings()
        {
            //Controller.Run<SettingsPresenter>();
        }
        private void Help()
        {
            //Controller.Run<HelpPresenter>();
        }
        private void About()
        {
            //Controller.Run<AboutPresenter>();
        }
    }
}