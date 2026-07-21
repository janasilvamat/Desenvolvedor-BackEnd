//Declaração de variáveis
double bAse;
double altura;
double area;
double perimetro;
double diagonal;

//Entrada de dados
Console.WriteLine("Digite a base do retângulo (em metros): ");
bAse = double.Parse(Console.ReadLine());
Console.WriteLine("Digite a altura do retângulo (em metros): ");
altura = double.Parse(Console.ReadLine());

//Processamento de dados
area = bAse * altura;
perimetro = bAse+altura * 2;
diagonal = Math.Sqrt(Math.Pow(bAse, 2) + Math.Pow(altura, 2));

//S
Console.WriteLine($"--Dados do retângulo--\n" +
   $"A área do terreno é: {area:f2}\n" +
   $"O perímetro do terreno é: {perimetro:f4}\n" +
   $"O diagonal do terreno é: {diagonal:f2}");

