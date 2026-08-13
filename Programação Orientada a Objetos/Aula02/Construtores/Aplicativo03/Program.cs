using Aplicativo03;

string nomedoaluno;
double nota1, nota2, nota3;

Console.Write("Nome do aluno: ");
nomedoaluno = Console.ReadLine();

Console.WriteLine("Nota as três notas do aluno: ");
nota1 = double.Parse(Console.ReadLine());
nota2 = double.Parse(Console.ReadLine());
nota3 = double.Parse(Console.ReadLine());

Aluno aluno = new Aluno(nomedoaluno, nota1, nota2, nota3);
aluno.ExibirDados();
aluno.PontosFaltando();

Console.WriteLine();
Console.ReadKey();
