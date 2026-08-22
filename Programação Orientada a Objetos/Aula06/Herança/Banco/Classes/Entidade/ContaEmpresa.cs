

namespace Banco.Classes.Entidade
{
    internal class ContaEmpresa : Conta
    {
        //Campos
        private double limite;



        //Propriedades
        protected double LimiteDeEmprestimo
        {
            get { return limite; }
            set { limite = value; }
        }

        //Construtor
        public ContaEmpresa(int numeroDaConta, string titularDaConta, double limite) : base(numeroDaConta, titularDaConta)
        {
            LimiteDeEmprestimo = limite;
        }

        public ContaEmpresa(int numeroDaConta, string titularDaConta, double saldoDaConta, double limite) : base(numeroDaConta, titularDaConta, saldoDaConta)
        {
            LimiteDeEmprestimo = limite;
        }

        //Métodos
        public override string ToString()
        {
            return $"Dados da conta: \n" +
                $"\t Titular: {TitularDaConta} \n" +
                $"\t Número: {NumeroDaConta} \n" +
                $"\t Saldo: {SaldoDaConta:c}\n" +
                $"\t Limite: {LimiteDeEmprestimo: c}\n";
        }

        public void Emprestimo(double quantia)
        {
            LimiteDeEmprestimo -= quantia;
            SaldoDaConta += quantia;
        }

       

    }
}
