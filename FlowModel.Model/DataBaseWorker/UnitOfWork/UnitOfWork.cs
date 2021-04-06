// ReSharper disable FieldCanBeMadeReadOnly.Local
namespace FlowModel.Model
{
    public class UnitOfWork : IUnitOfWork
    {
        private DataBaseContext _context;
        
        private Repository<User> _users;
        private Repository<Unit> _units;
        private Repository<Report> _reports;
        private Repository<Material> _materials;
        private Repository<Parameter> _parameters;
        private Repository<Coefficient> _coefficients;
        private Repository<MaterialParameters> _materialParameters;
        private Repository<MaterialCoefficients> _materialCoefficients;

        public UnitOfWork(DataBaseContext context)
        {
            _context = context;
        }

        public IRepository<User> Users => _users ?? (_users = new Repository<User>(_context));
        
        public IRepository<Unit> Units => _units ?? (_units = new Repository<Unit>(_context));
        
        public IRepository<Report> Reports => _reports ?? (_reports = new Repository<Report>(_context));
        
        public IRepository<Material> Materials => _materials ?? (_materials = new Repository<Material>(_context));
        
        public IRepository<Parameter> Parameters => _parameters ?? (_parameters = new Repository<Parameter>(_context));

        public IRepository<Coefficient> Coefficients =>
            _coefficients ?? (_coefficients = new Repository<Coefficient>(_context));

        public IRepository<MaterialParameters> MaterialParameters => _materialParameters ??
                                                                     (_materialParameters =
                                                                         new Repository<MaterialParameters>(_context));

        public IRepository<MaterialCoefficients> MaterialCoefficients => _materialCoefficients ??
                                                                         (_materialCoefficients =
                                                                             new Repository<MaterialCoefficients>(
                                                                                 _context));

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}