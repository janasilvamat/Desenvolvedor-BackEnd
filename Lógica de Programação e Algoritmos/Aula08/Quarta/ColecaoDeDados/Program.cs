//Coleção de Dados
/* -- Array --*/ /*Mesmo tipo, com tamanho fixo, não pode ser alterado ao longo do programa.
 
 */
/*
int[] numeros = { 0, 1, 2, 10, 4 };
string[] nomes = { "Lucas", "João", "Maria" };
Console.WriteLine(numeros.Length);

Console.WriteLine(numeros[3]);
numeros[3] = 56;
Console.WriteLine(nomes[1]);
*/


/*Dicionário
//declaração do dicionário. Não é tamanho fixo, é dinamico, pode mudar ao longo do programa. 
//Não permite chaves duplicadas, mas permite valores duplicados. A chave é única e o valor pode ser repetido.*/
/*
Dictionary<string, double> salarios = new Dictionary<string, double>() 
{
    { "Alice", 1.73},
    { "Bob", 62.9},
    { "clodoaldo", 14}
};
Console.WriteLine(salarios);
salarios.Add("Senai", 8.96);
Console.WriteLine(salarios["Senai"]);

foreach (var item in salarios)
{
    Console.WriteLine(item.Key + " tem " + item.Value);
}

if (salarios.ContainsKey("Bob"))
{
    Console.WriteLine("Bob está na coleção");
}
*/

/*Lista*/
//Declaração da lista. Não é tamanho fixo, é dinamico, pode mudar ao longo do programa.
// Permite valores duplicados, mas não permite chaves duplicadas. A chave é única e o valor pode ser repetido.
/*
List<int> Lista1 = new List<int>();
Lista1.Add(5600);
Lista1.Add(600);
Lista1.Add(0);
Lista1.Add(50);
Console.WriteLine(Lista1);

Lista1.Insert(2, 900);
//Lista1.Remove(600);

foreach (var item in Lista1)
{
    Console.WriteLine(item);
}
*/

/*Tuplas*/
//Declaração da tupla. Não é tamanho dinamico, é fixo. Permite mudar os valores ao longo do programa.
var pessoa = ("Cesar", 34, 2.5, 'M');
Console.WriteLine(pessoa.Item1); //Cesar
Console.WriteLine(pessoa.Item2); // Idade
Console.WriteLine(pessoa.Item3); // Altura
Console.WriteLine(pessoa.Item4); // Genero

var  pessoa2 = (Nome: "Janaína", idade: 41, altura: 1.67, genero: 'F');

Console.WriteLine(pessoa2);