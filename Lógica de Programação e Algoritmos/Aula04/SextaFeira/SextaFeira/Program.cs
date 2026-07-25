//Problema "idades"

//Declaração de Variáveis
/*
var nome1 = "Senai";
var nome2 = "Senai";
var idade1 = 1;
var idade2 = 2;
var media = 1.73;

//Entrada de Dados
Console.WriteLine("Dados da 1ª pessoa");
Console.Write("Nome: ");
nome1 = Console.ReadLine();
Console.Write("Idade: ");
idade1 = int.Parse(Console.ReadLine());
Console.WriteLine("Dados da 2ª pessoa");
Console.Write("Nome: ");
nome2= Console.ReadLine();
Console.Write("Idade: ");
idade2= int.Parse(Console.ReadLine());

//Processamento de Dados
media=(idade1 + idade2) / 2;

//Saída de dados
Console.WriteLine($"A média das idades de {nome1} e {nome2} é de {media:f1}");
*/

using System.Threading.Channels;

var x = int.Parse(Console.ReadLine());
var y = int.Parse(Console.ReadLine());
x = x / y;
y = y / x;
Console.WriteLine(x-y);