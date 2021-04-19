using System.Linq;

namespace FlowModel.Model.LoginService
{
    public class LoginService : ILoginService
    {
        public bool Login(User user)
        {
            var userUnitOfWork = new MockUserUnitOfWork();
            var users = userUnitOfWork.Users.GetList().ToList();
            
            return users.Where(x => x.Login == user.Login).Any(x => x.Password == user.Password);
        }
    }
}