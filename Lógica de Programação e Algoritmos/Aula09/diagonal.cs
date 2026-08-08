//Declaração de variáveis
int n, negativos = 0;
int [,] matriz;

while (true)
{
    //Primeira entrada de dados
    Console.Write("Digite o tamanho da matriz: ");
    n = int.Parse(Console.ReadLine());
    if (n > 10)
    {
        Console.WriteLine("Tamanho da matriz maior que 10, tente novamente.");
        continue;
    }

    matriz = new int[n, n];
   //Segunda entrada de dados
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"Elemento [{i},{j}]: ");
            matriz[i, j] = int.Parse(Console.ReadLine());
        }
    }

    //Exibição da matriz
    Console.Write("\nDiagonal principal: ");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i == j)
            {
                Console.Write(matriz[i, j] + "\t");
            }
        }
    }
    Console.Write("\nQuantidade de números negativos: ");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (matriz[i, j] < 0)
            {
                negativos++;
            }
        }
    }
    Console.WriteLine(negativos);
    break;
}