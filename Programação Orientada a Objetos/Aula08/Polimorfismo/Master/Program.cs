using Master.Classes.Entidades;
using Master.Enumeracoes;
/*
Conta contajana = new Conta("Jana", 12345, 1000);
Conta contNic = new ContaPoupanca("Nicolas", 52645, 10);
Conta technic = new ContaEmpresa("Mange", 59687, 1000);*/

//Declaração de variáveis
Conta conta;
string titular;
int numero;
double saldo, limite, taxa;

//Entrada de dados
Console.WriteLine("Selecione uma das opções: " +
    "\n 1 - Conta Pessoa Física" + "\n 2 - Conta Poupança" + "\n 3 - Conta Empresa" + "\nDeseja abrir qual tipo de conta?");
int escolha = int.Parse(Console.ReadLine());

switch (escolha)
{
    case 1:
        Console.WriteLine($"Tipo escolhido = {TipoConta.Conta_Normal}");
        AbrirConta();
        break;
    case 2:
        Console.WriteLine($"Tipo escolhido = {TipoConta.Conta_Poupanca}");
        AbrirPoupanca(); 
        break;
    case 3:
        Console.WriteLine($"Tipo escolhido = {TipoConta.Conta_Empresa}");
        AbrirEmpresa();
        break;
    default:
        Console.WriteLine("Nenhuma opção selecionada");
        conta = null;
        break;
}
conta.ExibirDados();
void AbrirConta()
{
    Console.Write("\nTitular da conta: ");
    titular = Console.ReadLine();
    Random random = new Random();
    numero = random.Next(1000, 6000);
    Console.Write($"\nNúmero da conta: {numero}");
    Console.WriteLine("\nDeseja fazer depósito inicial? (s/n) ");
    char opcion = char.Parse(Console.ReadLine().ToLower());
    if (opcion == 's')
    {
        Console.Write("Qual valor do depósito inicial: ");
        saldo = double.Parse(Console.ReadLine());
        conta = new Conta(titular, numero, saldo);
    }
    else
    {
        conta = new Conta(titular, numero);
    }
}

    void AbrirPoupanca()
    {
        Console.Write("\nTitular da conta: ");
        titular = Console.ReadLine();
        Random random = new Random();
        numero = random.Next(1000, 6000);
        Console.Write($"\nNúmero da conta: {numero}");
        Console.Write("\nTaxa da conta: ");
        taxa = double.Parse(Console.ReadLine());
        Console.WriteLine("\nDeseja fazer depósito inicial? (s/n) ");
        char opcion = char.Parse(Console.ReadLine().ToLower());
        if (opcion == 's')
        {
            Console.Write("Qual valor do depósito inicial: ");
            saldo = double.Parse(Console.ReadLine());
            conta = new ContaPoupanca(titular, numero, saldo, taxa);
        }
        else
        {
            conta = new ContaPoupanca(titular, numero, taxa);
        }
    }

    void AbrirEmpresa()
    {
        Console.Write("\nTitular da conta: ");
        titular = Console.ReadLine();
        Random random = new Random();
        numero = random.Next(1000, 6000);
        Console.Write($"\nNúmero da conta: {numero}");
        Console.Write("\nLimite da conta: ");
        limite = double.Parse(Console.ReadLine());
        Console.WriteLine("\nDeseja fazer depósito inicial? (s/n) ");
        char opcion = char.Parse(Console.ReadLine().ToLower());
        if (opcion == 's')
        {
            Console.Write("Qual valor do depósito inicial: ");
            saldo = double.Parse(Console.ReadLine());
            conta = new ContaEmpresa(titular, numero, saldo, limite);
        }
        else
        {
            conta = new ContaEmpresa(titular, numero, limite);
        }


    }
