using static System.Console;

//Declaração de variáveis
double salarioHora;
double salarioBruto;
double salarioLiquido;
double qtdHora;
double iRenda;
double inss = 0.1;
double fgts = 0.11;
double descontos;



try
{
    Console.Write("Informe o valor do salário hora: ");
    salarioHora = double.Parse(Console.ReadLine());
    Console.Write("\nInforme as horas trabalhadas: ");
    qtdHora = double.Parse(Console.ReadLine());

    salarioBruto = salarioHora * qtdHora;

    if (salarioBruto <= 900.00)
    {
        iRenda = 0;
    }
    else if (salarioBruto > 900.00 && salarioBruto <= 1500.00)
    {
        iRenda = 0.05;
    }
    else if (salarioBruto > 1500.00 && salarioBruto <= 2500.00)
    {
        iRenda = 0.10;
    }
    else
    {
        iRenda = 0.20;
    }
    Holerite();

    Console.Write($"\nSalário Bruto R$: {salarioBruto:f2}");
    Console.Write($"\n(-)IR: {salarioBruto * iRenda:f2}");
    Console.Write($"\n(-)INSS(10%) R$: {salarioBruto * inss:f2}");
    Console.Write($"\nFGTS(11%) R$: {salarioBruto * fgts:f2}");
    Console.Write($"\nTotal de descontos R$: {descontos:f2}");
    Console.Write($"\nSalário Líquido R$: {salarioLiquido:f2}");

}
catch
{
    Console.WriteLine("\nDados inválidos!");
}


void Holerite()
{
    descontos = (salarioBruto * iRenda) + (salarioBruto * inss);
    salarioLiquido = salarioBruto - descontos;
}

ReadKey();


