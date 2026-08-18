
namespace Banco
{
    public class ContaBancaria
    {
        //1º - Campos
        private string titular;
        private int numero;
        private double saldo;

        //2º - Propriedades
        protected string TitularDaConta
        {
            get { return titular; }
            set { 
            if (value != null | value != "")        
                {
                    titular = value;
                }
            else
                {
                    Console.WriteLine("Valor de campo inválido");
                }
            }
        }

        
        protected int NumeroDaConta
        {
            get { return numero; }
            private set { numero = value; }
        }
      

        protected double SaldoDaConta
        {
            get { return saldo; }
            set { saldo = value; }
        }

        //3º - Construtor
        public ContaBancaria(string titularDaConta, int numeroDaConta, double saldoDaConta)
        {
            TitularDaConta = titularDaConta;
            NumeroDaConta = numeroDaConta;
            SaldoDaConta = saldoDaConta;
        }

        public ContaBancaria(string titularDaConta, int numeroDaConta)
        {
            TitularDaConta = titularDaConta;
            NumeroDaConta = numeroDaConta;
            SaldoDaConta = 0.0;
        }

        //4º - Métodos
        public void Deposito(double quantia)
        {
            SaldoDaConta += quantia;
        }

        public void Saque(double quantia)
        {
            if (quantia <= 0)
            {
                Console.WriteLine("Valor inválido, insira um valor positivo ou diferente de zero.");
            }
            else
            {
                SaldoDaConta -= quantia + 5.00;  
            }
        }

        public string ExibirDados()
        {
            return $"Dados da conta: \n" + 
                   $" \tTitular: {TitularDaConta}\n" + 
                   $" \tNúmero da Conta: {NumeroDaConta}\n" + 
                   $" \tSaldo: {SaldoDaConta:C}";

        }
    }
}
