namespace FlowModel.Model
{
    public class UserUnitOfWork : UnitOfWork<UserDbContext>
    {
        private Repository<User, UserDbContext> _users;
     
        public UserUnitOfWork(UserDbContext context) : base(context)
        {
        }

        public IRepository<User> Users => _users ?? (_users = new Repository<User, UserDbContext>(Context));
    }
}