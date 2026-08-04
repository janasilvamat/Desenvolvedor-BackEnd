using static System.Console;

//Declaração de variáveis
int n;
double  x, y;

try
{
    //Entrada de dados
    Console.Write("Quantos casos você vai digitar? ");
    n= int.Parse(ReadLine());
    for (int i = 0; i < n; i++)

    {
        Console.Write("Entre com o numerador: ");
        x = double.Parse(ReadLine());
        Console.Write("Entre com o denominador: ");
        y = double.Parse(ReadLine());

        if (y != 0)
        {
            Console.WriteLine($"Divisão = {(x/y):f2}");
        }
        else
        {
            Console.WriteLine("Divisão impossível");
        }
    }
}
catch (Exception erro)
{
    WriteLine($"Por favor, insira um número válido, erro: {erro} ");
}