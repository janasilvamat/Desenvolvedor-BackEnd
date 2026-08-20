

namespace Banco.Classes.Entidades
{
    internal class ContaPessoaFisica
    {
		//Campos
		private string titular;
		private int numero;
		private double saldo;


        //Propriedades
		protected string TitularDaConta
		{
			get { return titular; }
			set { titular = value; }
		}
        protected int NumeroDaConta
		{
			get { return numero; }
			set { numero = value; }
		}
		protected double SaldoDaConta
		{
			get { return saldo; }
			set { saldo = value; }
		}

		//Construtor
        public ContaPessoaFisica(int numeroDaConta, string titularDaConta)
        {
            NumeroDaConta = numeroDaConta;
            TitularDaConta = titularDaConta;
			SaldoDaConta = 0;
        }

        public ContaPessoaFisica(int numeroDaConta, string titularDaConta, double saldoDaConta) : this(numeroDaConta, titularDaConta)
        {
            SaldoDaConta = saldoDaConta;
        }

		//Métodos
		public void Saque(double quantia)
		{
			SaldoDaConta -= quantia;
		}

		public void Deposito(double quantia)
		{
			SaldoDaConta += quantia;
		}
    }
}
