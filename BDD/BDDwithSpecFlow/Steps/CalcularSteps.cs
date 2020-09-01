using BDDwithSpecFlow.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace BDDwithSpecFlow.Features
{
	[Binding]
	public class CalcularSteps
	{
		private readonly ScenarioContext _scenarioContext;

		private Calculadora calculadora = new Calculadora();
		private int result;

		public CalcularSteps(ScenarioContext scenarioContext)
		{
			_scenarioContext = scenarioContext;
		}

		[Given(@"que o primeiro número é (.*)")]
		public void DadoQueOPrimeiroNumeroE(int valor1)
		{
			calculadora.PrimeiroNumero = valor1;
		}

		[Given(@"o segundo número é (.*)")]
		public void DadoOSegundoNumeroE(int valor2)
		{
			calculadora.SegundoNumero = valor2;
		}

		[When(@"os dois números forem somados")]
		public void QuandoOsDoisNumerosForemSomados()
		{
			result = calculadora.Somar();
		}

		[Then(@"o resultado da resposta deverá ser (.*)")]
		public void EntaoOResultadoDaRespostaDeveraSer(int expectedResult)
		{
			Assert.AreEqual(expectedResult, result);
		}
	}
}
