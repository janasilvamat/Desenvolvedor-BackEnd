namespace Aplicativo02
{
    internal class Funcionario
    {
        string nome;
        double salarioBruto;
        double imposto;

        public Funcionario(string nome, double salarioBruto, double imposto)
        {
            this.nome = nome;
            this.salarioBruto = salarioBruto;
            this.imposto = imposto;
        }

        public double SalarioLiquido()
        {
            return salarioBruto - imposto;
        }
        public double AumentarSalario(double porcentagem)
        {
            salarioBruto += salarioBruto * porcentagem / 100;
            return salarioBruto;
        }   

        public void ExibirDados()
        {
            Console.WriteLine($"Dados do funcionário atualizados \nNome do funcionário: {nome} \nSalário líquido: R$ {SalarioLiquido():c}");
        }
    }
}
