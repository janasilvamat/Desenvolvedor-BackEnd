using Aplicativo02;

string nome;
double salarioBruto, imposto, porcentagem;

Console.Write("Digite o nome do funcionário: ");
nome = Console.ReadLine();

Console.Write("Digite o salário bruto do funcionário: ");
salarioBruto = double.Parse(Console.ReadLine());

Console.Write("Digite o imposto sobre o salário: ");
imposto = double.Parse(Console.ReadLine());

Funcionario funcionario = new Funcionario(nome, salarioBruto, imposto);
funcionario.ExibirDados();

Console.Write("Digite a porcentagem de aumento do salário do funcionário: ");
porcentagem = double.Parse(Console.ReadLine());
funcionario.AumentarSalario(porcentagem);
Console.WriteLine("Dados Atualizados");
funcionario.ExibirDados();

Console.WriteLine();
Console.ReadKey();
