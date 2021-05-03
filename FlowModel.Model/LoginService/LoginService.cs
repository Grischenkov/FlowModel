using System;
using System.Linq;

namespace FlowModel.Model.LoginService
{
    public class LoginService : ILoginService
    {
        public User Login(User user)
        {
            var userUnitOfWork = new UserUnitOfWork(new UserDbContext());
            var users = userUnitOfWork.Users.GetList().ToList();

            foreach (var x in users.Where(x => x.Login == user.Login).Where(x => x.Password == user.Password))
            {
                return x;
            }

            throw new Exception();
        }
    }
}