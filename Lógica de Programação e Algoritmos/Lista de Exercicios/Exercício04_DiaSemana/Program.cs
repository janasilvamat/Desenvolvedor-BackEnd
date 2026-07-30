using System.ComponentModel.Design;
using static System.Console;

//Declaração de variáveis

int numero;

try
    
{
    Console.Write("Informe um número de 1 a 7: ");
    numero = int.Parse(Console.ReadLine());

    if (numero == 1)
    {
        Console.WriteLine("\nHoje é Domingo");
    }
    else if (numero == 2)
    {
        Console.WriteLine("\nHoje é Segunda-Feira");
    }
    else if (numero == 3)
    {
        Console.WriteLine("\nHoje é Terça-Feira");
    }
    else if (numero == 4)
    {
        Console.WriteLine("\nHoje é Quarta-Feira");
    }
    else if (numero == 5)
    {
        Console.WriteLine("\nHoje é Quinta-Feira");
    }
    else if (numero == 6)
    {
        Console.WriteLine("\nHoje é Sexta-Feira");
    }
    else if(numero == 7) 
    {
        Console.WriteLine("\nHoje é Sábado");
    }
    else
    {
        Console.WriteLine("\nInformação inválida!");
    }
}
catch
{
    Console.WriteLine("\nInformação Inválida!");
}

ReadKey();
