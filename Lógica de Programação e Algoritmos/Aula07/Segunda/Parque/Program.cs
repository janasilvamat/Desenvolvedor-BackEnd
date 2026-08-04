//Declaração de variáveis
int codigo, veiculo, turistas;
string entrando, voltando, sair;
veiculo = 0;
turistas = 0;
codigo = 0;

while (true)
{
    try
    {
        Console.Write("Digite 1 se veículo entrando, 2 se veículo voltando ou 0 para sair? ");
        codigo = int.Parse(Console.ReadLine());

        if (codigo == 0)
        {
            Console.Write("Encerrando o programa");
            break;
        }
        Console.Write("Quantas pessoas tem no veículo? ");
        turistas = int.Parse(Console.ReadLine());
        if (turistas >4)
        {
            Console.WriteLine("O veículo não pode ter mais de 4 pessoas, tente novamente.");
            continue;
        }

        if (codigo == 1)
        {
            veiculo += turistas;
            Console.WriteLine($"O veiculo entrou com {turistas} pessoas, \nTotal de pessoas no parque: {veiculo}");
        }
        else if (codigo == 2)
        {
            veiculo -= turistas;
            Console.WriteLine($"O veículo saiu do parque com {turistas} pessoas, \nTotal de pessoas no parque: {veiculo}");
        }
    }
    catch (Exception erro)
    {
        Console.WriteLine($"Valor inválido, erro: {erro}");
    }

}
