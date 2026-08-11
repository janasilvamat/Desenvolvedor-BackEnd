//Entrada de dados
Console.Write ("Base do Retângulo: ");
double baseR = double.Parse(Console.ReadLine());
Console.Write("Altura do Retângulo: ");
double alturaR = double.Parse(Console.ReadLine());
//Processamento
double area = Area(baseR, alturaR);
double perimetro = Perimetro(baseR, alturaR);
double diagonal = Diagonal(baseR, alturaR);

//Saída de dados
Console.WriteLine($"Área: {area:f4}, Perímetro: {perimetro:f4}, Diagonal: {diagonal:f4}");

//Funções
double Area(double b, double a)
{
    return b * a;
}

double Perimetro(double b, double a)
{
    return 2 * (b + a);
}     

double Diagonal(double b, double a)
{
    return Math.Sqrt((b * b) + (a * a));
}