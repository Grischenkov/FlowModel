using System;
using System.Windows.Forms;
using FlowModel.Presenter.Views;

namespace FlowModel
{
    public partial class LoginView : Form, ILoginView
    {
        private readonly ApplicationContext _context;
        
        public string Login
        {
            get => login_TextBox.Text;
        }

        public string Password
        {
            get => password_TextBox.Text;
        }

        public LoginView(ApplicationContext context)
        {
            _context = context;
            
            InitializeComponent();

            login_Button.Click += (sender, args) => Action(Log);
        }

        public new void Show()
        {
            try
            {
                _context.MainForm = this;
                Application.Run(_context);
            }
            catch
            {
                _context.MainForm = this;
                base.Show();
            }
        }

        public void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowWarning(string warningMessage)
        {
            MessageBox.Show(warningMessage, @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void ShowSuccess(string successMessage)
        {
            MessageBox.Show(successMessage, @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public event Action Log;
        
        private void Action(Action action)
        {
            try
            {
                action?.Invoke();
            }
            catch (Exception e)
            {
                ShowError(e.Message);
            }
        }
    }
}