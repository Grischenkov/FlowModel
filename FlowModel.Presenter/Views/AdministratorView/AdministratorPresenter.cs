using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using FlowModel.Model;
using FlowModel.Presenter.ParentInterfaces;
using FlowModel.Presenter.Views.AboutView;

namespace FlowModel.Presenter.Views.AdministratorView
{
    public class AdministratorPresenter : BasePresenter<IAdministratorView>
    {
        private enum Actions
        {
            Add, 
            Update,
            Delete
        }
        
        public AdministratorPresenter(IApplicationController controller, IAdministratorView view) : base(controller, view)
        {
            InitializeCombo();
            InitializeTable();

            View.AddMaterial += () => Material(Actions.Add);
            View.DeleteMaterial += () => Material(Actions.Delete);

            View.AddParameter += () => Parameter(Actions.Add);
            View.DeleteParameter += () => Parameter(Actions.Delete);
            
            View.AddType += () => Type(Actions.Add);
            View.DeleteType += () => Type(Actions.Delete);
            
            View.AddUnit += () => Unit(Actions.Add);
            View.DeleteUnit += () => Unit(Actions.Delete);
            
            View.AddMaterialParameter += () => MaterialParameters(Actions.Add);
            View.DeleteMaterialParameter += () => MaterialParameters(Actions.Delete);
            
            View.AddUser += () => User(Actions.Add);
            View.DeleteUser += () => User(Actions.Delete);
            
            View.DeleteReport += () => Report(Actions.Delete);
            
            View.Open += Open;
            View.Save += Save;
            View.Export += Export;
            View.Logout += Logout;
            View.Exit += Exit;

            View.Settings += Settings;
            View.Help += Help;
            View.About += About;
        }

        private void Logout()
        {
            Controller.Run<LoginPresenter>();
            View.Close();
        }
        
        private void Action<TEntity>(TEntity entity, DbContext context, Actions action) where TEntity : class, IEntity
        {
            using (var repository = new Repository<TEntity, DbContext>(context))
            {
                switch (action)
                {
                    case Actions.Add:
                        repository.Insert(entity);
                        View.ShowSuccess("Запись успешно добавлена.");
                        break;
                    case Actions.Update:
                        repository.Update(entity);
                        View.ShowSuccess("Запись успешно обновлена.");
                        break;
                    case Actions.Delete:
                        repository.Delete(entity);
                        View.ShowSuccess("Запись успешно удалена.");
                        break;
                }
                context.SaveChanges();
            }
        }
        
        private void ProcessEntity<TEntity>(TEntity entity, DbContext context, Actions action) where TEntity : class, IEntity
        {
            DbContext dbContext = null;
            switch (context.GetType().Name)
            {
                case "ProcessDbContext":
                    dbContext = new ProcessDbContext();
                    break;
                case "UserDbContext":
                    dbContext = new UserDbContext();
                    break;
                case "ReportDbContext":
                    dbContext = new ReportDbContext();
                    break;
            }
            
            switch (action)
            {
                case Actions.Add:
                    var isContains = false;
                    using (var repository = new Repository<TEntity, DbContext>(context))
                    {
                        isContains = repository.GetList().Any(x => x.Id == entity.Id);
                    }
                    Action(entity, dbContext, isContains ? Actions.Update : Actions.Add);
                    break;
                case Actions.Delete:
                    Action(entity, dbContext, Actions.Delete); 
                    break;
            }
            
            InitializeCombo();
            InitializeTable();
        }
        
        private void Material(Actions action)
        {
            if (string.IsNullOrEmpty(View.MaterialId))
            {
                throw new ArgumentNullException("Id материала");
            }
            if (string.IsNullOrEmpty(View.MaterialName))
            {
                throw new ArgumentNullException("Имя материала");
            }
            
            var material = new Material
            {
                Id = Convert.ToInt32(View.MaterialId),
                Name = View.MaterialName,
            };

            ProcessEntity(material, new ProcessDbContext(), action);
            
            View.MaterialId = "";
            View.MaterialName = "";
        }

        private void Parameter(Actions action)
        {
            if (string.IsNullOrEmpty(View.ParameterId))
            {
                throw new ArgumentNullException("Id параметра");
            }
            if (string.IsNullOrEmpty(View.ParameterName))
            {
                throw new ArgumentNullException("Имя параметра");
            }
            if (string.IsNullOrEmpty(View.ParameterType))
            {
                throw new ArgumentNullException("Тип параметра");
            }
            if (string.IsNullOrEmpty(View.ParameterUnit))
            {
                throw new ArgumentNullException("Единица измерения параметра");
            }
            
            Parameter parameter;
            using (var unitOfWork = new ProcessUnitOfWork(new ProcessDbContext()))
            {
                parameter = new Parameter
                {
                    Id = Convert.ToInt32(View.ParameterId),
                    Name = View.ParameterName,
                    TypeId = unitOfWork.Types.GetList().First(x => x.Name == View.ParameterType).Id,
                    UnitId = unitOfWork.Units.GetList().First(x => x.Name == View.ParameterUnit).Id
                };   
            }

            ProcessEntity(parameter, new ProcessDbContext(), action);
            
            View.ParameterId = "";
            View.ParameterName = "";
            View.ParameterType = "";
            View.ParameterUnit = "";
        }

        private void Type(Actions action)
        {
            if (string.IsNullOrEmpty(View.TypeId))
            {
                throw new ArgumentNullException("Id типа парметра");
            }
            if (string.IsNullOrEmpty(View.TypeName))
            {
                throw new ArgumentNullException("Имя параметра");
            }
            
            var type = new Model.Type
            {
                Id = Convert.ToInt32(View.TypeId),
                Name = View.TypeName,
            };

            ProcessEntity(type, new ProcessDbContext(), action);
            
            View.TypeId = "";
            View.TypeName = "";
        }
        
        private void Unit(Actions action)
        {
            if (string.IsNullOrEmpty(View.UnitId))
            {
                throw new ArgumentNullException("Id единицы измерения");
            }
            if (string.IsNullOrEmpty(View.UnitName))
            {
                throw new ArgumentNullException("Единица измерения");
            }
            
            var unit = new Unit
            {
                Id = Convert.ToInt32(View.UnitId),
                Name = View.UnitName,
            };

            ProcessEntity(unit, new ProcessDbContext(), action);
            
            View.UnitId = "";
            View.UnitName = "";
        }
        
        private void MaterialParameters(Actions action)
        {
            if (string.IsNullOrEmpty(View.MaterialParametersId))
            {
                throw new ArgumentNullException("Id параметра материала");
            }
            if (string.IsNullOrEmpty(View.MaterialItem))
            {
                throw new ArgumentNullException("Материал");
            }
            if (string.IsNullOrEmpty(View.ParameterItem))
            {
                throw new ArgumentNullException("Параметр");
            }
            if (string.IsNullOrEmpty(View.ParameterValue))
            {
                throw new ArgumentNullException("Значение параметра");
            }
            
            MaterialParameters materialParameters;
            using (var unitOfWork = new ProcessUnitOfWork(new ProcessDbContext()))
            {
                materialParameters = new MaterialParameters()
                {
                    Id = Convert.ToInt32(View.MaterialParametersId),
                    MaterialId = unitOfWork.Materials.GetList().First(x => x.Name == View.MaterialItem).Id,
                    ParameterId = unitOfWork.Parameters.GetList().First(x => x.Name == View.ParameterItem).Id,
                    ParameterValue = Convert.ToDouble(View.ParameterValue.Replace('.', ','))
                };   
            }

            ProcessEntity(materialParameters, new ProcessDbContext(), action);
            
            View.MaterialParametersId = "";
            View.MaterialItem = "";
            View.ParameterItem = "";
            View.ParameterValue = "";
        }
        
        private void User(Actions action)
        {
            if (string.IsNullOrEmpty(View.UserId))
            {
                throw new ArgumentNullException("Id пользователя");
            }
            if (string.IsNullOrEmpty(View.UserLogin))
            {
                throw new ArgumentNullException("Логин");
            }
            if (string.IsNullOrEmpty(View.UserPassword))
            {
                throw new ArgumentNullException("Пароль");
            }
            
            var user = new User()
            {
                Id = Convert.ToInt32(View.UserId),
                Login = View.UserLogin,
                Password = View.UserPassword,
                IsAdministrator = View.UserStatus
            };

            ProcessEntity(user, new UserDbContext(), action);
            
            View.UserId = "";
            View.UserLogin = "";
            View.UserPassword = "";
            View.UserStatus = false;
        }
        
        private void Report(Actions action)
        {
            if (string.IsNullOrEmpty(View.ReportId))
            {
                throw new ArgumentNullException("Id отчета");
            }
            if (string.IsNullOrEmpty(View.ReportDate))
            {
                throw new ArgumentNullException("Дата отчета");
            }
            if (string.IsNullOrEmpty(View.ReportName))
            {
                throw new ArgumentNullException("Имя отчета");
            }
            
            var report = new Report()
            {
                Id = Convert.ToInt32(View.ReportId)
            };

            ProcessEntity(report, new ReportDbContext(), action);    
            
            View.ReportId = "";
            View.ReportDate = "";
            View.ReportName = "";
        }
        
        private void InitializeTable()
        {
            int i;
            
            using (var unitOfWork = new ProcessUnitOfWork(new ProcessDbContext()))
            {
                var materials = new string[unitOfWork.Materials.GetList().Where(x => true).Count()][];
                i = 0;
                foreach (var material in unitOfWork.Materials.GetList())
                {
                    materials[i] = new string[2];
                    materials[i][0] = material.Id.ToString();
                    materials[i][1] = material.Name;
                    i++;
                }
                View.FillMaterialsRecords(materials);

                var materialParameters = new string[unitOfWork.MaterialParameters.GetList().Count()][];
                i = 0;
                foreach (var materialParameter in unitOfWork.MaterialParameters.GetList())
                {
                    materialParameters[i] = new string[4];
                    materialParameters[i][0] = materialParameter.Id.ToString();
                    materialParameters[i][1] = materialParameter.Material.Name;
                    materialParameters[i][2] = materialParameter.Parameter.Name;
                    materialParameters[i][3] = materialParameter.ParameterValue.ToString();
                    i++;
                }
                View.FillMaterialParametersRecords(materialParameters);

                var parameters = new string[unitOfWork.Parameters.GetList().Count()][];
                i = 0;
                foreach (var parameter in unitOfWork.Parameters.GetList())
                {
                    parameters[i] = new string[4];
                    parameters[i][0] = parameter.Id.ToString();
                    parameters[i][1] = parameter.Name;
                    parameters[i][2] = parameter.Type.Name;
                    parameters[i][3] = parameter.Unit.Name;
                    i++;
                }
                View.FillParametersRecords(parameters);

                var types = new string[unitOfWork.Types.GetList().Count()][];
                i = 0;
                foreach (var type in unitOfWork.Types.GetList())
                {
                    types[i] = new string[2];
                    types[i][0] = type.Id.ToString();
                    types[i][1] = type.Name;
                    i++;
                }
                View.FillTypesRecords(types);

                var units = new string[unitOfWork.Units.GetList().Count()][];
                i = 0;
                foreach (var unit in unitOfWork.Units.GetList())
                {
                    units[i] = new string[2];
                    units[i][0] = unit.Id.ToString();
                    units[i][1] = unit.Name;
                    i++;
                }
                View.FillUnitsRecords(units);                
            }
         
            using (var unitOfWork = new UserUnitOfWork(new UserDbContext()))
            {
                var users = new string[unitOfWork.Users.GetList().Count()][];
                i = 0;
                foreach (var user in unitOfWork.Users.GetList())
                {
                    users[i] = new string[4];
                    users[i][0] = user.Id.ToString();
                    users[i][1] = user.Login;
                    users[i][2] = user.Password;
                    users[i][3] = user.IsAdministrator.ToString();
                    i++;
                }
                View.FillUsersRecords(users);
            }
         
            using (var unitOfWork = new ReportUnitOfWork(new ReportDbContext()))
            {
                var reports = new string[unitOfWork.Reports.GetList().Count()][];
                i = 0;
                foreach (var report in unitOfWork.Reports.GetList())
                {
                    reports[i] = new string[3];
                    reports[i][0] = report.Id.ToString();
                    reports[i][1] = report.DateTime.ToString("d");
                    reports[i][2] = report.Name;
                    i++;
                }
                View.FillReportsRecords(reports);
            }
        }

        private void InitializeCombo()
        {
            View.MaterialItemsClear();
            View.ParameterItemsClear();
            View.UnitItemsClear();
            View.TypeItemsClear();
            
            using (var unitOfWork = new ProcessUnitOfWork(new ProcessDbContext()))
            {
                foreach (var material in unitOfWork.Materials.GetList())
                {
                    View.MaterialItem = material.Name;
                }
                foreach (var parameter in unitOfWork.Parameters.GetList())
                {
                    View.ParameterItem = parameter.Name;
                }
                foreach (var type in unitOfWork.Types.GetList())
                {
                    View.TypeItem = type.Name;
                }
                foreach (var unit in unitOfWork.Units.GetList())
                {
                    View.UnitItem = unit.Name;
                }
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
            Controller.Run<AboutPresenter>();
        }
    }
}