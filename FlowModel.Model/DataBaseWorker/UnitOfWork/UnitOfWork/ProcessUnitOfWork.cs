// ReSharper disable RedundantDefaultMemberInitializer
// ReSharper disable FieldCanBeMadeReadOnly.Local
namespace FlowModel.Model
{
    public class ProcessUnitOfWork : UnitOfWork<ProcessDbContext>
    {
        private Repository<Unit, ProcessDbContext> _units;
        private Repository<Type, ProcessDbContext> _types;
        private Repository<Material, ProcessDbContext> _materials;
        private Repository<Parameter, ProcessDbContext> _parameters;
        private Repository<MaterialParameters, ProcessDbContext> _materialParameters;

        public ProcessUnitOfWork(ProcessDbContext context) : base(context)
        {
        }

        public IRepository<Type> Types => _types ?? (_types = new Repository<Type, ProcessDbContext>(Context));

        public IRepository<Unit> Units => _units ?? (_units = new Repository<Unit, ProcessDbContext>(Context));

        public IRepository<Material> Materials =>
            _materials ?? (_materials = new Repository<Material, ProcessDbContext>(Context));

        public IRepository<Parameter> Parameters =>
            _parameters ?? (_parameters = new Repository<Parameter, ProcessDbContext>(Context));

        public IRepository<MaterialParameters> MaterialParameters => _materialParameters ??
                                                                     (_materialParameters =
                                                                         new Repository<MaterialParameters,
                                                                             ProcessDbContext>(Context));
    }
}