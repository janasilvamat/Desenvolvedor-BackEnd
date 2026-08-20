
namespace Contrato.Classes.Contratos
{
    internal class HoraContrato
    {
		//Campos
		private int horas;
		private double valor;


        //Propriedades
        protected double ValorPorHora
		{
			get { return valor; }
			set { valor = value; }
		}
		protected int HorasTrabalhadas
		{
			get { return horas; }
			set { horas = value; }
		}

		//Construtor
        public HoraContrato(double valorPorHora, int horasTrabalhadas)
        {
            ValorPorHora = valorPorHora;
            HorasTrabalhadas = horasTrabalhadas;
        }

		//Método
		public double Pagamento()
		{
			return ValorPorHora + HorasTrabalhadas;
		}
	}
}
