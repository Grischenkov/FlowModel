using System;
using System.Windows.Forms;

namespace FlowModel
{
    internal static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IApplicationController controller = new ApplicationController(new LightInjectAdapter())
                .RegisterView<IMainView, MainView>
                .RegisterInstance(new ApplicationContext());
            
            controller.Run<MainPresenter>();
        }
    }
}