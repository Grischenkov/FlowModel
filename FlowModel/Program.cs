﻿using System;
using System.Windows.Forms;
using FlowModel.Presenter;
using FlowModel.Presenter.ParentInterfaces;

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
                //.RegisterView<IMainView, MainView>
                .RegisterInstance(new ApplicationContext());

            //controller.Run<MainPresenter>();
            Application.Run(new ResearcherView());
        }
    }
}