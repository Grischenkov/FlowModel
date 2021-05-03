using System;
using System.Security.Authentication;
using FlowModel.Model;
using FlowModel.Model.LoginService;
using FlowModel.Presenter.ParentInterfaces;
using FlowModel.Presenter.Views.AdministratorView;
using FlowModel.Presenter.Views.ResearcherView;

namespace FlowModel.Presenter.Views
{
    public class LoginPresenter : BasePresenter<ILoginView>
    {
        private readonly ILoginService _loginService;
        
        public LoginPresenter(IApplicationController controller, ILoginView view, ILoginService loginService) : base(controller, view)
        {
            _loginService = loginService;
            
            View.Log += Login;
        }

        private void Login()
        {
            CheckInput(View.Login, "Логин");
            CheckInput(View.Password, "Пароль");

            var user = new User
            {
                Login = View.Login, 
                Password = View.Password
            };
            
            Login(user);
        }

        private void CheckInput(string value, string name)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(name);
            }
        }

        private void Login(User user)
        {
            try
            {
                user = _loginService.Login(user);
                if (user.IsAdministrator)
                {
                    Controller.Run<AdministratorPresenter>();
                }
                else
                {
                    Controller.Run<ResearcherPresenter>();
                }
                View.Close();
            }
            catch
            {
                throw new AuthenticationException($"Неверный Логин или Пароль. \n Если вы забыли учетные данные обратитесь к администратору системы.");
            }
        }
    }
}