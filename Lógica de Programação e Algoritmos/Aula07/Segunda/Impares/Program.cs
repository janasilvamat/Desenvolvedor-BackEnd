using static System.Linq.Enumerable;
using static System.Console;

//Declaração de variáveis

int x,y, controle, control;
int impar = 0;

try
{
    //Entrada de dados
    WriteLine("Digite dois números: ");
    x = int.Parse(ReadLine());
    y = int.Parse(ReadLine());

    //Processamento de dados


    if (x < y)
    {
        controle = x;
        control = y;
    }
    else
    {
        controle = y;
        control = x;
    }
    foreach (int a in Range(controle, control))
    {
        if (a % 2 != 0 & a != x & a != y)
        {
            impar += a;
        }
            if (a==control)
            {
                break;
            }
        }
    
    WriteLine($"Soma dos ímpares: {impar}");
}
catch (Exception erro)
{
    WriteLine($"Por favor, insira um número válido, erro: {erro} ");
}
