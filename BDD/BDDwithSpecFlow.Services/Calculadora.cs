namespace BDDwithSpecFlow.Services
{
	public class Calculadora
	{
		public int PrimeiroNumero { get; set; }
		public int SegundoNumero { get; set; }


		public int Somar()
		{
			return PrimeiroNumero + SegundoNumero;
		}
	}
}
