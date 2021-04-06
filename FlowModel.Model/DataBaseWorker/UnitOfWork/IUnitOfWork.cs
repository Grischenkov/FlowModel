namespace FlowModel.Model
{
    public interface IUnitOfWork
    {
        IRepository<User> Users { get; }
        IRepository<Unit> Units { get; }
        IRepository<Report> Reports { get; }
        IRepository<Material> Materials { get; }
        IRepository<Parameter> Parameters { get; }
        IRepository<Coefficient> Coefficients { get; }
        IRepository<MaterialParameters> MaterialParameters { get; }
        IRepository<MaterialCoefficients> MaterialCoefficients { get; }
        
        void Commit();
    }
}