using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using FlowModel.Model;
using FlowModel.Presenter.ParentInterfaces;
using FlowModel.Presenter.Properties;

namespace FlowModel.Presenter.Views.AdministratorView
{
    public class AdministratorPresenter : BasePresenter<IAdministratorView>
    {
        private readonly MockProcessUnitOfWork _processUnitOfWork;
        private readonly MockUserUnitOfWork _userUnitOfWork;
        private readonly MockReportUnitOfWork _reportUnitOfWork;
        
        public AdministratorPresenter(IApplicationController controller, IAdministratorView view) : base(controller, view)
        {
            _processUnitOfWork = new MockProcessUnitOfWork();
            _userUnitOfWork = new MockUserUnitOfWork();
            _reportUnitOfWork = new MockReportUnitOfWork();


            InitializeCombo();
            InitializeTable();

            View.Open += Open;
            View.Save += Save;
            View.Export += Export;
            View.Exit += Exit;

            View.Settings += Settings;
            View.Help += Help;
            View.About += About;
        }

        private void InitializeTable()
        {
            var materials = new string[_processUnitOfWork.Materials.GetList().Count()][];
            var i = 0;
            foreach (var material in _processUnitOfWork.Materials.GetList())
            {
                materials[i] = new string[2];
                materials[i][0] = material.Id.ToString();
                materials[i][1] = material.Name;
                i++;
            }
            View.FillMaterialsRecords(materials);

            var materialParameters = new string[_processUnitOfWork.MaterialParameters.GetList().Count()][];
            i = 0;
            foreach (var materialParameter in _processUnitOfWork.MaterialParameters.GetList())
            {
                materialParameters[i] = new string[4];
                materialParameters[i][0] = materialParameter.Id.ToString();
                materialParameters[i][1] = materialParameter.Material.Name;
                materialParameters[i][2] = materialParameter.Parameter.Name;
                materialParameters[i][3] = materialParameter.ParameterValue.ToString();
                i++;
            }
            View.FillMaterialParametersRecords(materialParameters);

            var parameters = new string[_processUnitOfWork.Parameters.GetList().Count()][];
            i = 0;
            foreach (var parameter in _processUnitOfWork.Parameters.GetList())
            {
                parameters[i] = new string[4];
                parameters[i][0] = parameter.Id.ToString();
                parameters[i][1] = parameter.Name;
                parameters[i][2] = parameter.Type.Name;
                parameters[i][3] = parameter.Unit.Name;
                i++;
            }
            View.FillParametersRecords(parameters);

            var types = new string[_processUnitOfWork.Types.GetList().Count()][];
            i = 0;
            foreach (var type in _processUnitOfWork.Types.GetList())
            {
                types[i] = new string[2];
                types[i][0] = type.Id.ToString();
                types[i][1] = type.Name;
                i++;
            }
            View.FillTypesRecords(types);

            var units = new string[_processUnitOfWork.Units.GetList().Count()][];
            i = 0;
            foreach (var unit in _processUnitOfWork.Units.GetList())
            {
                units[i] = new string[2];
                units[i][0] = unit.Id.ToString();
                units[i][1] = unit.Name;
                i++;
            }
            View.FillUnitsRecords(units);

            var users = new string[_userUnitOfWork.Users.GetList().Count()][];
            i = 0;
            foreach (var user in _userUnitOfWork.Users.GetList())
            {
                users[i] = new string[4];
                users[i][0] = user.Id.ToString();
                users[i][1] = user.Login;
                users[i][2] = user.Password;
                users[i][3] = user.IsAdministrator.ToString();
                i++;
            }
            View.FillUsersRecords(users);

            var reports = new string[_reportUnitOfWork.Reports.GetList().Count()][];
            i = 0;
            foreach (var report in _reportUnitOfWork.Reports.GetList())
            {
                reports[i] = new string[3];
                reports[i][0] = report.Id.ToString();
                reports[i][1] = report.DateTime.ToString("d");
                reports[i][2] = report.Name;
                i++;
            }
            View.FillReportsRecords(reports);
        }

        private void InitializeCombo()
        {
            foreach (var material in _processUnitOfWork.Materials.GetList())
            {
                View.MaterialItem = material.Name;
            }

            foreach (var parameter in _processUnitOfWork.Parameters.GetList())
            {
                View.ParameterItem = parameter.Name;
            }

            foreach (var type in _processUnitOfWork.Types.GetList())
            {
                View.TypeItem = type.Name;
            }

            foreach (var unit in _processUnitOfWork.Units.GetList())
            {
                View.UnitItem = unit.Name;
            }
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