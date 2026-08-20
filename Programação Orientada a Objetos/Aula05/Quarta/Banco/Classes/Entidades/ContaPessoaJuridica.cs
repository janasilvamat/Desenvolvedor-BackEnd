
namespace Banco.Classes.Entidades
{
    internal class ContaPessoaJuridica : ContaPessoaFisica
    {
		//Campo
		private double limite;


        //Propriedades
        protected double LimiteDaConta
		{
			get { return limite; }
			set { limite = value; }
		}

		//Construtor
        public ContaPessoaJuridica(int numeroDaConta, string titularDaConta, double limite) : base(numeroDaConta, titularDaConta)
        {
            LimiteDaConta = limite;
        }

        public ContaPessoaJuridica(int numeroDaConta, string titularDaConta, double saldoDaConta, double limite) : base(numeroDaConta, titularDaConta, saldoDaConta)
        {
            LimiteDaConta = limite;
        }

        //Métodos
        public void Limite(double quantia)
        {
            SaldoDaConta += quantia;
        }
	}
}
