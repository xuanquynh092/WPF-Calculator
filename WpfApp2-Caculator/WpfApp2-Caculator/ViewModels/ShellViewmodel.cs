using Microsoft.Practices.Prism.Commands;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2_Caculator.Core.Calculator;
using WpfApp2_Caculator.ViewModels.Base;

namespace WpfApp2_Caculator.ViewModels
{
	 public class ShellViewmodel: ViewModelBase
	{
		private readonly ICalculator _calculator;
		public ShellViewmodel(ICalculator calculator)
		{
			_calculator = calculator;

		}

		public ShellViewmodel()
		{
		}

		public string Title { get; } = "Calculator";
		private string _expression =string.Empty;
		private bool hasCalculator;
		public string Experession
		{
			get => _expression;
			set => SetProperty(ref _expression, value);
		}
		public DelegateCommand<object>  AddNumberCommand { get; set; }
		public DelegateCommand ClearCmd { get; set; }
		public DelegateCommand DelCmd { get; set; }
		public DelegateCommand EqualsCmd { get; set; }
		protected override void RegisterCommands()
		{
			AddNumberCommand = new DelegateCommand<object>(AddNumber);
			ClearCmd = new DelegateCommand(Clear);
			EqualsCmd = new DelegateCommand(Calculate);
			DelCmd = new DelegateCommand(DelTxt);
		}

		private void Calculate()
		{
			try
			{
				if (Experession != null)
				{
					//Experession = _calculator.Calculator(Experession).ToString("N2");

					var dataTbl = new DataTable();
					var value = dataTbl.Compute(Experession, "");
					Experession = value.ToString();


				}
				hasCalculator = true;
			}
			catch (Exception ex )
			{
				Experession = string.Empty;
				
			}
		}
		
		private void Clear()
		{
			Experession = string.Empty;
		}

		private void AddNumber(object objValue)
		{
			if (hasCalculator)
			{
				Clear();
				hasCalculator = false;
			}
			Experession += objValue.ToString();
		}
		private void DelTxt()
		{
			
			if (String.IsNullOrEmpty(Experession))
			{
				 Experession = Experession;
			}
			else
			{
				Experession= Experession.TrimEnd(Experession[Experession.Length - 1]);
			}
		}
	}
}
