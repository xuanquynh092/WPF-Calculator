using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApp2_Caculator.Core.Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2_Caculator.Core.Calculator.Tests
{
	[TestClass()]
	public class ExpessionCalculatorTests
	{
		[TestMethod()]
		public void CalculatorTest()
		{
			var expression = "2+2";
			var calculator = new ExpessionCalculator();
			var value = calculator.Calculator(expression);
			Assert.AreEqual(4, value);
		}
	}
}