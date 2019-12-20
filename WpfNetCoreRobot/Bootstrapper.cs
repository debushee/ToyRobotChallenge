using System;
using System.Collections.Generic;
using System.Text;
using Caliburn.Micro;
using WpfNetCoreRobot.ViewModels;

namespace WpfNetCoreRobot
{
    public class Bootstrapper: BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }

        protected override void OnStartup(object sender, System.Windows.StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
