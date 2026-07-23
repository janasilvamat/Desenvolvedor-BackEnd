int primeiroNumero;
int segundoNumero;
int terceiroNumero;

Console.Write("Digite o primeiro número: ");
primeiroNumero = int.Parse(Console.ReadLine());
Console.Write("Digite o segundo número: ");
segundoNumero = int.Parse(Console.ReadLine());
Console.Write("Digite o terceiro número: ");
terceiroNumero = int.Parse(Console.ReadLine());

//Processamento de dados
bool resultado1 = primeiroNumero == terceiroNumero;
bool resultado2 = primeiroNumero != segundoNumero;
bool resultado3 = segundoNumero > primeiroNumero;
bool resultado4 = segundoNumero <= terceiroNumero;

//saída de dados
Console.WriteLine($"\nO primeiro valor é igual ao terceiro valor? R: {(resultado1 ? "Verdadeiro" : "Falso")}");
Console.WriteLine($"O primeiro valor é diferente do segundo valor? R:  {(resultado2 ? "Verdadeiro" : "Falso")}");
Console.WriteLine($"O segundo valor é maior que o primeiro valor? R:  {(resultado3 ? "Verdadeiro" : "Falso" )}");
Console.WriteLine($"O segundo valor é menor ou igual ao terceiro valor? R:  {(resultado4 ? "Verdadeiro" : "Falso")}");

// Operadores ternários
bool pergunta1e3 = resultado1 && resultado3;    // 1. pergunta 1 e pergunta 3 são verdadeiras?
bool pergunta2ou4 = resultado2 || resultado4;   // 2. pergunta 2 e pergunta 4: pelo menos uma é verdadeira?
bool negacaoPerg1 = !resultado1;                // 3. negação da primeira pergunta é verdadeira?


// Saída das respostas
Console.WriteLine("\n1. Pergunta 1 E Pergunta 3 são verdadeiras? R: " + pergunta1e3);
Console.WriteLine("2. Pergunta 2 OU Pergunta 4 (pelo menos uma)? R: " + pergunta2ou4);
Console.WriteLine("3. A negação da primeira pergunta é verdadeira? R: " + negacaoPerg1);






