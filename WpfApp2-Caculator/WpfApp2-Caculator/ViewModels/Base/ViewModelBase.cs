using Prism.Mvvm;

namespace WpfApp2_Caculator.ViewModels.Base
{
	public abstract class ViewModelBase : BindableBase
	{
		protected ViewModelBase(){

			RegisterCommands();
		}


		protected virtual void RegisterCommands()
		{

		}
	}
}
