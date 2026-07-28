//Declaração de variáveis
double nota1, nota2, notafinal;

try
{
    //Entrada de dados
    Console.Write("Digite a primeira nota: ");
    nota1 = double.Parse(Console.ReadLine());
    Console.Write("Digite a segunda nota: ");
    nota2 = double.Parse(Console.ReadLine());

    //Processamento de dados
    Nota();
    //Saída de dados
    Console.WriteLine($"Nota Final = {notafinal:f1}");
    if (notafinal > 60 & notafinal < 70)
    {
        Console.WriteLine("Aluno em recuperação");
    }
    else if (notafinal == 80)
    {
        Console.WriteLine("Aluno Aprovado com Distinção");
    }   
    else
    {
        Console.WriteLine("Aluno Aprovado");
    }
}
catch 
{
    Console.WriteLine("Digite valores válidos");
}

double Nota()
{
    notafinal = nota1 + nota2;
    return notafinal;
}