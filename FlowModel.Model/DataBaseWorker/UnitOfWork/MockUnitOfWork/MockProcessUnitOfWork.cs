namespace FlowModel.Model
{
    public class MockProcessUnitOfWork : UnitOfWork<ProcessDbContext>
    {
        private MockRepository<Unit> _units;
        private MockRepository<Type> _types;
        private MockRepository<Material> _materials;
        private MockRepository<Parameter> _parameters;
        private MockRepository<MaterialParameters> _materialParameters;

        public IRepository<Type> Types => _types ?? (_types = new MockRepository<Type>());

        public IRepository<Unit> Units => _units ?? (_units = new MockRepository<Unit>());

        public IRepository<Material> Materials =>
            _materials ?? (_materials = new MockRepository<Material>());

        public IRepository<Parameter> Parameters =>
            _parameters ?? (_parameters = new MockRepository<Parameter>());

        public IRepository<MaterialParameters> MaterialParameters => _materialParameters ??
                                                                     (_materialParameters =
                                                                         new MockRepository<MaterialParameters>());
    }
}