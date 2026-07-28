//Declaração de variáveis
double a, b, c, perimetro, trapezio;

try
{
    //Entrada de dados
    Console.WriteLine("Digite a medida do lado A: ");
    a = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a medida do lado B: ");
    b = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a medida do lado C: ");
    c = double.Parse(Console.ReadLine());


    if (a + b > c & b + c > a & c + a > b)
    {
        //Processamento de dados
        AreaTriangulo();

        //Saída de Dados
        Console.WriteLine($"O perímetro é:{perimetro:f1}");

    }

    else
    {
        AreaTrapezio();
        Console.WriteLine($"Área do trapézio é: {trapezio:f1}");
    }
}
catch
{
    Console.WriteLine("Digite valores válidos");
}


double AreaTriangulo()
{
    perimetro = a + b + c;
    return perimetro;
}
double AreaTrapezio()
{
    trapezio = ((a + b) * c) / 2;
    return trapezio;
}

