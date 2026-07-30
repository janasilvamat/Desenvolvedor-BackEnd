using static System.Console;

//Declaração de variáveis
string M = "Matutino";
string V = "Vespertino";
string N = "Noturno";


//Entrada de dados
try
{
    Console.Write("Digite o período que você estuda (M, V ou N): ");
    char periodo = char.Parse (Console.ReadLine());

    //Estrutura condicional para verificar o período
    if (periodo == 'M')
    {
        Console.WriteLine("\nBom dia!");
    }
    else if  (periodo == 'V')
    {
        Console.WriteLine("\nBoa tarde!");
    }
    else if  (periodo == 'N')
    {
        Console.WriteLine("\nBoa noite!");
    }
    else
    {
        Console.WriteLine("\nValor Inválido!");
    }

}
catch 
{
    Console.WriteLine("\nErro!");
}

ReadKey();