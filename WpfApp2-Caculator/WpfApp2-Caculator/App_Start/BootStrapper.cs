
using System.Windows;
using Microsoft.Practices.Unity;
using System.ComponentModel;
using System;
using Prism.Unity;
using Microsoft.Practices.Prism.UnityExtensions;
using WpfApp2_Caculator.Views;

namespace WpfApp2_Caculator.App_Start
{

	public class BootStrapper : UnityBootstrapper
	{
		protected override DependencyObject CreateShell()
		{
			return Container.Resolve<Shell>();
		}

		protected override void InitializeShell()
		{
			Application.Current.MainWindow?.Show();
		}
		protected override void ConfigureContainer()
		{
			base.ConfigureContainer();
			Container.RegisterInstances();
		}
	}
}
