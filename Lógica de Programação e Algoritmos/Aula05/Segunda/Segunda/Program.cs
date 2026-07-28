
const string janela= "Problema medidas";

Console.Title = janela;

//Declaração de variáveis

double a, b, c, quadrado, triangulo, trapezio;

//Entrada de dados
Console.Write("Digite o valor do lado A: ");
a = double.Parse(Console.ReadLine());
Console.Write("Digite o valor do lado B: ");
b = double.Parse(Console.ReadLine());
Console.Write("Digite o valor do lado C: ");
c = double.Parse(Console.ReadLine());

//Processamento de dados

AreaQuadrado();
AreaTriangulo();
AreaTrapezio();

//Saída de dados
Saida();

Console.ReadKey();

double AreaQuadrado()
{
    quadrado = a * a;
    return quadrado;
}

double AreaTriangulo()
{
    triangulo = (a * b) / 2;
    return triangulo;
}

double AreaTrapezio()
{
    trapezio = ((a + b) * c) / 2;
    return trapezio;
}

void Saida()
{
    Console.WriteLine($"\nÁrea do quadrado é {quadrado:f4}\n" +
        $"Área do triangulo é {triangulo:f4}\n" +
        $"Área do trapezio é {trapezio:f4}");
}
