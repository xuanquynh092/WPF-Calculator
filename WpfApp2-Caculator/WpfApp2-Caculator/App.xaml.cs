
using System.Windows;
using Bootstrapper = WpfApp2_Caculator.App_Start.BootStrapper;
namespace WpfApp2_Caculator
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		protected override void OnStartup(StartupEventArgs e)
		{
			new Bootstrapper().Run();
		}
	}
}
