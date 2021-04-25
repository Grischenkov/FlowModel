using System.Linq;
using FlowModel.Model;

namespace FlowModel.Presenter
{
    public static class DataBaseInitializer
    {
        public static void Initialize()
        {
            using (var unitOfWork = new UserUnitOfWork(new UserDbContext()))
            {
                var mockUnitOfWork = new MockUserUnitOfWork();
                if (unitOfWork.Users.GetList().Any()) return;
                foreach (var user in mockUnitOfWork.Users.GetList())
                {
                    unitOfWork.Users.Insert(user);
                }
                unitOfWork.Commit();
            }

            using (var unitOfWork = new ReportUnitOfWork(new ReportDbContext()))
            {
                var mockUnitOfWork = new MockReportUnitOfWork();
                if(unitOfWork.Reports.GetList().Any()) return;
                foreach (var report in mockUnitOfWork.Reports.GetList())
                {
                    unitOfWork.Reports.Insert(report);
                }
                unitOfWork.Commit();
            }

            using (var unitOfWork = new ProcessUnitOfWork(new ProcessDbContext()))
            {
                var mockUnitOfWork = new MockProcessUnitOfWork();
                if (unitOfWork.Units.GetList().Any() || unitOfWork.Types.GetList().Any() || unitOfWork.Parameters.GetList().Any()
                    || unitOfWork.Materials.GetList().Any() || unitOfWork.MaterialParameters.GetList().Any()) return;
                foreach (var unit in mockUnitOfWork.Units.GetList())
                {
                    unitOfWork.Units.Insert(unit);
                }
                foreach (var type in mockUnitOfWork.Types.GetList())
                {
                    unitOfWork.Types.Insert(type);
                }
                foreach (var parameter in mockUnitOfWork.Parameters.GetList())
                {
                    unitOfWork.Parameters.Insert(parameter);   
                }
                foreach (var material in mockUnitOfWork.Materials.GetList())
                {
                    unitOfWork.Materials.Insert(material);
                }
                foreach (var materialParameter in mockUnitOfWork.MaterialParameters.GetList())
                {
                    unitOfWork.MaterialParameters.Insert(materialParameter);
                }
                unitOfWork.Commit();
            }
        }
    }
}