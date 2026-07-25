//DateTime
//TimeSpan
/*
var horario = DateTime.Now;

DateTime data1 = new(1991, 8, 27);
DateTime data2 = new DateTime(1993, 6, 7);
var data = data1.AddDays(10);

Console.WriteLine(data);
*/

//Problema "duracao"

//Declaração de Variáveis

int segundos, minutos, hora;

//Entrada de Dados

Console.Write("Digite a duração em segundos: ");
int totalsegundos = int.Parse(Console.ReadLine());

//Processamento de Dados
hora = totalsegundos / 3600;
minutos = (totalsegundos % 3600) / 60;
segundos = (totalsegundos % 3600) % 60;

//Saída de dados
Console.WriteLine($"{hora}:{minutos}:{segundos}");
