using System.Runtime.InteropServices;
bool sair = true;
while (sair = !false)
{

    Console.WriteLine("Selecione o tipo de conta que deseja abrir: \n" + "\t 1 - Conta normal \n" +
        "\t 2 - Conta Poupança\n" + "\t 3 - Conta Empresa\n" + "\t 4 - Sair");


    int selecao = int.Parse(Console.ReadLine());
    switch (selecao)
    {
        case 1:
            Console.WriteLine("Selecionada conta normal");
            break;
        case 2:
            Console.WriteLine("Selecionada conta poupança");
            break;
        case 3:
            Console.WriteLine("Selecionada conta empresa");
            break;
        default:
            Console.WriteLine("Necessário selecionar uma opção!");
            break;
    }
}

void Opcao1()
{
    Console.WriteLine("Deseja fazer depósito inicial? (s/n)");
    char op = char.Parse(Console.ReadLine().ToLower());
    if (op == 'n')
    {

    }
    else
    {
        Console.WriteLine("Qual o valor do depósito inicial?");
    }
}