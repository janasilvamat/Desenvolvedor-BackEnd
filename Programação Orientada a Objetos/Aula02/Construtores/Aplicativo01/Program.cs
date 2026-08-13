using Aplicativo01;

double largura, altura;

Console.WriteLine("Digite a largura e depois a altura do retângulo: ");
largura = double.Parse(Console.ReadLine());
altura = double.Parse(Console.ReadLine());

Retangulo retangulo = new Retangulo(largura, altura);
retangulo.ExibirDados();

Console.WriteLine();

