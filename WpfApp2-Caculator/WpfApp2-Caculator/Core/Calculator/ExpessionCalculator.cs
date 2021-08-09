using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2_Caculator.Core.Calculator
{
	public class ExpessionCalculator : ICalculator
	{
		public double Calculator(string expression)
		{
			var dataTbl = new DataTable();
			var value = dataTbl.Compute(expression, "");
			return Convert.ToDouble(value);
		}
	}
}
