using Banco.Classes.Contextos;
using Banco.Classes.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.Json;

ContaContext contexto = new ContaContext();

contexto.Database.EnsureCreated();

bool continuar = true;
while (continuar)
{
    Console.WriteLine("Menu Principal" +
        "\n 1 - Cadastrar conta" +
        "\n 2 - Consultar conta" +
        "\n 3 - Sair");
    Console.Write("\n Escolha uma opção: ");
    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            //Cadastrar conta
            CadastrarConta(contexto);
            break;
        case "2":
            //Consultar uma conta
            ConsultaConta(contexto);
            break;
        case "3":
            continuar = false;
            Console.WriteLine("Encerrando sistema...");
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void CadastrarConta(ContaContext conta)
{
    Console.WriteLine("--Cadastro de Conta--\n");
    Console.Write("Digite o número da conta: ");
    int numero = int.Parse(Console.ReadLine());
    Console.Write("Digite o titular da conta: ");
    string titular = Console.ReadLine();
    Console.Write("Terá depósito inicial (s/n)? ");
    char escolha = char.Parse(Console.ReadLine().ToLower());

    var numeroContaExistente = conta.Contas.FirstOrDefault(C => C.NumeroDaConta == numero);
    Conta contacriada;
    if (numeroContaExistente != null)
    {
        Console.WriteLine($"\n Erro: Já existe um conta com o número {numero}");
        return;
    }
    if (escolha.Equals('s'))
    {
        Console.Write("Valor do depósito inicial: ");
        decimal deposito = decimal.Parse(Console.ReadLine());
        contacriada = new Conta(numero, titular, deposito);
    }
    else
    {
        contacriada = new Conta(numero, titular, 0);
    }
    conta.Contas.Add(contacriada);//Create
    conta.SaveChanges();
    Console.WriteLine("\nConta cadastrada com sucesso!");
    contacriada.ExibirDados();
}
void ConsultaConta(ContaContext conta)
{
    Console.WriteLine("--Consulta de Conta--");
    Console.Write("Digite o número da conta: ");
    int numero = int.Parse(Console.ReadLine());
    var contaConsultada = conta.Contas.FirstOrDefault(c => c.NumeroDaConta == numero);
    if (contaConsultada == null)
    {
        Console.WriteLine($"\n Conta {numero} não encontrada!");
        return;
    }
    contaConsultada.ExibirDados();//Read

    continuar = true;

    while (continuar)
    {
        Console.WriteLine("--Operações--");
        Console.WriteLine("1 - Depositar");
        Console.WriteLine("2 - Sacar");
        Console.WriteLine("3 - Alterar titular");
        Console.WriteLine("4 - Voltar ao menu principal");
        Console.WriteLine("\n Escolha uma opção: ");
        int opcao = int.Parse(Console.ReadLine());
        switch (opcao)
        {
            case 1:
                //Operação de depósito
                Console.Write("Digite o valor do depósito: ");
                decimal valor = decimal.Parse(Console.ReadLine());
                contaConsultada.Depositar(valor);
                conta.SaveChanges();
                contaConsultada.ExibirDados();
                break;
            case 2:
                //Sacar
                Console.Write("Digite o valor para sacar: ");
                valor = decimal.Parse(Console.ReadLine());
                contaConsultada.Sacar(valor);
                conta.SaveChanges();
                contaConsultada.ExibirDados();
                break;
            case 3:
                //Alterar titular
                Console.Write("Digite o novo titular da conta: ");
                string novoTitular = Console.ReadLine();
                contaConsultada.TitularDaConta = novoTitular;
                conta.SaveChanges();
                contaConsultada.ExibirDados();
                break;
            case 4:
                //Sair
                return;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}
