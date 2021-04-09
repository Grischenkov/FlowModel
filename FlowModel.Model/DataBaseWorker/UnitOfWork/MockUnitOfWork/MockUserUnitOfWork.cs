namespace FlowModel.Model
{
    public class MockUserUnitOfWork : UnitOfWork
    {
        private MockRepository<User> _users;

        public IRepository<User> Users => _users ?? (_users = new MockRepository<User>());
    }
}