using static System.Console;

//Declaração de variáveis
double salario;
double aumento;
double percentual;
double salarioNovo;

// Entrada de dados
try
{
    Console.Write("Digite o salário do funcionário: ");
    salario = double.Parse(Console.ReadLine());

    if (salario <= 280)
    {
        percentual = 20;
        Calculos();
    }
    else if (salario > 280 && salario <= 700)
    {
        percentual = 15;
        Calculos();
    }
    else if (salario > 700 && salario <= 1500)
    {
        percentual = 10;
        Calculos();
    }
    else
    {
        percentual = 5;
        Calculos();
    }
    
    // Saída de dados
    Console.WriteLine($"\nSalário antes do reajuste: {salario:f2}");
    Console.WriteLine($"\nPercentual de aumento aplicado: {percentual}%");
    Console.WriteLine($"\nValor do aumento: {aumento:f2}");
    Console.WriteLine($"\nNovo salário, após o aumento: {salarioNovo:f2}");
}

catch
{
    Console.WriteLine("\nValor Inválido!");
}

ReadKey();

void Calculos()
{
    aumento = salario * percentual / 100;
    salarioNovo = salario + aumento;
}