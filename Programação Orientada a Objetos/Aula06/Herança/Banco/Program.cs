using Banco.Classes.Entidade;
using System.Runtime.InteropServices;
bool sair = false;

while (!sair)
{

    Console.WriteLine("Selecione o tipo de conta que deseja abrir: \n" + 
        "\t 1 - Conta normal \n" +
        "\t 2 - Conta Poupança\n" + 
        "\t 3 - Conta Empresa\n" + 
        "\t 4 - Sair");


    int selecao = int.Parse(Console.ReadLine());
    switch (selecao)
    {
        case 1:
            Console.WriteLine("Selecionada conta normal");
            Console.Write("\nNúmero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Titular: ");
            string titular = Console.ReadLine();

            Conta conta = new Conta(numero, titular);

            Opcao1(conta);

            Console.Write("\nDeseja fazer um saque? (s/n): ");
            char opSaque = char.Parse(Console.ReadLine().ToLower());

            if (opSaque == 's')
            {
                Console.Write("Digite o valor do saque: ");
                double valorSaque = double.Parse(Console.ReadLine());

                conta.Saque(valorSaque);
            }

            Console.WriteLine();
            Console.Write("Dados da conta após o saque:");
            Console.WriteLine(conta);

            break;
        case 2:
            Console.WriteLine("Selecionada conta poupança");
            Console.Write("\nNúmero da conta: ");
            int numeroPoupanca = int.Parse(Console.ReadLine());

            Console.Write("Titular: ");
            string titularPoupanca = Console.ReadLine();

            Console.Write("Taxa de juros: ");
            double taxa = double.Parse(Console.ReadLine());

            ContaPoupanca contaPoupanca = new ContaPoupanca(
                numeroPoupanca,
                titularPoupanca,
                taxa
            );

            Opcao1(contaPoupanca);

            Console.Write("\nDeseja fazer um saque? (s/n): ");
            char opSaquePoupanca = char.Parse(Console.ReadLine().ToLower());

            if (opSaquePoupanca == 's')
            {
                Console.Write("Digite o valor do saque: ");
                double valorSaque = double.Parse(Console.ReadLine());

                contaPoupanca.Saque(valorSaque);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(contaPoupanca);

            break;
        case 3:
            Console.WriteLine("Selecionada conta empresa");
            break;
        case 4:
            sair = true;
            break;
        default:
            Console.WriteLine("Necessário selecionar uma opção!");
            break;
    }
}

void Opcao1(Conta conta)
{
    Console.WriteLine("Deseja fazer depósito inicial? (s/n)");
    char op = char.Parse(Console.ReadLine().ToLower());
    if (op == 'n')
    {
        return;
    }
    else if (op == 's')
    {
        Console.WriteLine("Digite o valor do depósito: ");
        double valor = double.Parse(Console.ReadLine());

        conta.Deposito(valor);

    }
    else
    {
        Console.WriteLine("Opção ínválida!");
    }
}