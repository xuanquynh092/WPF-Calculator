using Microsoft.Practices.Unity;
using WpfApp2_Caculator.Core.Calculator;

namespace WpfApp2_Caculator.App_Start
{
	public static class UnityConfig
	{
		public static IUnityContainer RegisterInstances(this IUnityContainer container)
		{
			container.RegisterType<ICalculator, ExpessionCalculator>();
			return container;
		}
	}
}
