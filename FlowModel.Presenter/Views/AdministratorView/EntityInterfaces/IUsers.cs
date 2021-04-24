using System;

namespace FlowModel.Presenter.Views.AdministratorView.EntityInterfaces
{
    public interface IUsers
    {
        void FillUsersRecords(string[][] records);
        string UserId { get; set; }
        string UserLogin { get; set; }
        string UserPassword { get; set; }
        bool UserStatus { get; set; }
        event Action AddUser;
        event Action DeleteUser;
    }
}