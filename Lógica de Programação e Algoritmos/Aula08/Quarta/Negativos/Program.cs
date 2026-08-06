//Declaração de variáveis
List<int> numeros = new List<int>();
    int n, valor;
try
{
    //Entrada de dados
    Console.Write("Quantos numeros você vai digitar? ");
    n = int.Parse(Console.ReadLine());

    //Looping determinado
    for (int i = 0; i < n; i++)
    {
        Console.Write("Digite um número: ");
        valor = int.Parse(Console.ReadLine());
        numeros.Add(valor);
    }
    Console.WriteLine("Números Negativos: ");
    foreach (var item in numeros)
    {
        if (item < 0)
        {
            Console.WriteLine(item);
        }
    }
}
catch (Exception e)
{

    Console.WriteLine("Valor inválido, erro: " + e); ;
}
